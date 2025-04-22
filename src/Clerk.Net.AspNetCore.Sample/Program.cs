using Clerk.Net.AspNetCore.Sample;
using Clerk.Net.AspNetCore.Security;
using Clerk.Net.AspNetCore.Webhooks;
using Clerk.Net.AspNetCore.Webhooks.Models.User;
using Clerk.Net.DependencyInjection;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        corsBuilder =>
        {
            if (builder.Environment.IsProduction())
            {
                // configure for deployments
                corsBuilder
                    .WithOrigins($"https://{builder.Configuration["ClientUrl"]}");
            }
            else
            {
                corsBuilder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
            }

            corsBuilder
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});


// API Client
builder.Services.AddClerkApiClient(x =>
{
    x.SecretKey = builder.Configuration["Clerk:SecretKey"]!;
});

// Auth
builder.Services.AddAuthentication(ClerkAuthenticationDefaults.AuthenticationScheme)
    .AddClerkAuthentication(x =>
    {
        x.Authority = builder.Configuration["Clerk:Authority"]!;
        x.AuthorizedParty = builder.Configuration["Clerk:AuthorizedParty"]!;
    });

builder.Services.AddAuthorizationBuilder()
    .SetFallbackPolicy(new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build());

builder.Services.AddClerkWebhooks(x =>
{
    x.WebhookSecret = builder.Configuration["Clerk:WebhookSecret"]!;
}).RegisterHandler<UserCreatedEvent, UserCreatedHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return forecast;
    })
    .WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
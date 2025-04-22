using System.Text.Json.Serialization;

namespace Clerk.Net.AspNetCore.Webhooks.Models.User;

public class UserCreatedEvent
{
    [JsonPropertyName("data")]
    public UserData Data { get; set; }

    [JsonPropertyName("event_attributes")]
    public EventAttributes EventAttributes { get; set; }

    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public class UserData
{
    [JsonPropertyName("birthday")]
    public string Birthday { get; set; }

    [JsonPropertyName("created_at")]
    public long CreatedAt { get; set; }

    [JsonPropertyName("email_addresses")]
    public List<EmailAddress> EmailAddresses { get; set; }

    [JsonPropertyName("external_accounts")]
    public List<object> ExternalAccounts { get; set; }

    [JsonPropertyName("external_id")]
    public string ExternalId { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("image_url")]
    public string ImageUrl { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("last_sign_in_at")]
    public long LastSignInAt { get; set; }

    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("password_enabled")]
    public bool PasswordEnabled { get; set; }

    //TODO
    [JsonPropertyName("phone_numbers")]
    public List<object> PhoneNumbers { get; set; }

    [JsonPropertyName("primary_email_address_id")]
    public string PrimaryEmailAddressId { get; set; }

    [JsonPropertyName("primary_phone_number_id")]
    public object PrimaryPhoneNumberId { get; set; }

    [JsonPropertyName("primary_web3_wallet_id")]
    public object PrimaryWeb3WalletId { get; set; }

    [JsonPropertyName("private_metadata")]
    public Dictionary<string, object> PrivateMetadata { get; set; }

    [JsonPropertyName("profile_image_url")]
    public string ProfileImageUrl { get; set; }

    [JsonPropertyName("public_metadata")]
    public Dictionary<string, object> PublicMetadata { get; set; }

    [JsonPropertyName("two_factor_enabled")]
    public bool TwoFactorEnabled { get; set; }

    [JsonPropertyName("unsafe_metadata")]
    public Dictionary<string, object> UnsafeMetadata { get; set; }

    [JsonPropertyName("updated_at")]
    public long UpdatedAt { get; set; }

    [JsonPropertyName("username")]
    public object Username { get; set; }

    [JsonPropertyName("web3_wallets")]
    public List<object> Web3Wallets { get; set; }
}

public class EmailAddress
{
    [JsonPropertyName("email_address")]
    public string EmailAddressValue { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("linked_to")]
    public List<string> LinkedTo { get; set; }

    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("verification")]
    public Verification Verification { get; set; }
}

public class Verification
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("strategy")]
    public string Strategy { get; set; }
}

public class EventAttributes
{
    [JsonPropertyName("http_request")]
    public HttpRequest HttpRequest { get; set; }
}

public class HttpRequest
{
    [JsonPropertyName("client_ip")]
    public string ClientIp { get; set; }

    [JsonPropertyName("user_agent")]
    public string UserAgent { get; set; }
}
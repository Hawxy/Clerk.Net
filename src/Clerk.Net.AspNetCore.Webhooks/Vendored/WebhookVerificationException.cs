﻿namespace Svix.Exceptions
{
    internal class WebhookVerificationException : Exception
    {
        public WebhookVerificationException()
            : base() { }

        public WebhookVerificationException(string message)
            : base(message) { }

        public WebhookVerificationException(string message, Exception inner)
            : base(message, inner) { }
    }
}
using System;

namespace Amethral.Common.DTOs
{
    // Réponse à l'initialisation
    public class WebTokenResponse
    {
        public string DeviceCode { get; set; } = string.Empty; // Secret for Unity
        public string UserCode { get; set; } = string.Empty;   // Display to User
        public string VerificationUrl { get; set; } = string.Empty; // URL to enter code
        public DateTime ExpiresAt { get; set; }
    }

    // Réponse finale (Victoire !)
    public class AuthSuccessResponse
    {
        public string SessionToken { get; set; } = string.Empty; // Le sésame pour FishNet
        public string WebToken { get; set; } = string.Empty; // Le JWT pour l'API Web
        public string Username { get; set; } = string.Empty;
        public Guid UserId { get; set; }
    }

    public class UserProfileResponse
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
namespace Amethral.Common.DTOs
{
    // Réponse à l'initialisation
    public class WebTokenResponse
    {
        public string Token { get; set; } = string.Empty;
        public string AuthUrl { get; set; } = string.Empty; // URL à ouvrir dans le navigateur
        public DateTime ExpiresAt { get; set; }
    }

    // Réponse finale (Victoire !)
    public class AuthSuccessResponse
    {
        public string SessionToken { get; set; } = string.Empty; // Le sésame pour FishNet
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
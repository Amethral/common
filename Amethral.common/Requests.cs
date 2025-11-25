namespace Amethral.Common.DTOs
{
    // 1. Initier le handshake (Unity -> API)
    public class WebTokenRequest
    {
        public string DeviceId { get; set; } = string.Empty;
    }

    public class LinkSessionRequest
    {
        public string WebToken { get; set; } = string.Empty;
    }

    // 2. Polling pour vérifier le statut (Unity -> API)
    public class TokenStatusRequest
    {
        public string WebToken { get; set; } = string.Empty;
        public string DeviceId { get; set; } = string.Empty;
    }

    // 3. Login Classique (Web -> API)
    // Note: On passe le WebToken pour dire "C'est cet utilisateur Unity qui se connecte"
    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string WebToken { get; set; } = string.Empty;
    }

    // 4. Register Classique (Web -> API)
    public class RegisterRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string WebToken { get; set; } = string.Empty;
    }

    // 5. Google Auth (Web -> API)
    public class GoogleAuthRequest
    {
        public string IdToken { get; set; } = string.Empty; // Token JWT de Google
        public string WebToken { get; set; } = string.Empty;
    }
}
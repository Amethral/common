namespace Amethral.Common.DTOs
{
    public class RegisterRequest
    {
        public string Username { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;
    }

    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;
    }
    public class OAuthLinkRequest
    {
        public string Provider { get; set; } = string.Empty;
        public string ProviderKey { get; set; } = string.Empty;
    }
}
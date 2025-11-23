using System;

namespace Amethral.common
{
    [Serializable]
    public class RegisterRequest
    {
        public string Username;
        public string Password;
        public string Email;
    }

    [Serializable]
    public class LoginRequest
    {
        public string Username;
        public string Password;
    }

    [Serializable]
    public class AuthResponse
    {
        public bool Success;
        public string Message;
        public string Token;
    }
}
namespace Models.DTOs.Account
{
    public class AuthenticationRequestEmail
    {
        public string Email { get; set; }

        public string CccdId { get; set; }

        public string Name { get; set; }
    }

    public class ValidationAuthCode
    {
        public string Code { get; set; }

        public string ICCID { get; set; }
    }
}
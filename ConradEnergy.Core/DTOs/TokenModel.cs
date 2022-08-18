namespace ConradEnergy.Core.DTOs
{
    public class TokenModel
    {        
        public string Token { get; set; }        
        public DateTimeOffset TokenExpiry { get; set; }
    }
}

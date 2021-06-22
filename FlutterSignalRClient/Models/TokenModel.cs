using System;

namespace FlutterSignalRClient.Models
{
    public class TokenModel
    {
        public String AccessToken { get; set; }
        public DateTime Expiration { get; set; }
        public String RefreshToken { get; set; }
        public DateTime RefreshTokenEndDate { get; set; }
    }
}

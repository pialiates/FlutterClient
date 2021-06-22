using System;

namespace FlutterSignalRClient.Models
{
    public class UserModel : BaseModel
    {
        private Guid id;
        public Guid Id { get => id; set => SetProperty(ref id, value); }

        private String username;
        public String Username { get => username; set => SetProperty(ref username, value); }

        private String password;
        public String Password { get => password; set => SetProperty(ref password, value); }

        private TokenModel token;
        public TokenModel Token { get => token; set => SetProperty(ref token, value); }

        private SantralModel santral;
        public SantralModel Santral { get => santral; set => SetProperty(ref santral, value); }
    }
}

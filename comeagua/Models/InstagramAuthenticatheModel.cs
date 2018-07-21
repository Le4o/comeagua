namespace InstagramLogin.Models
{
    public class InstagramAuthenticateModel
    {
        public string access_token { get; set; }

        public InstagramUserInfo user { get; set; }
    }
}
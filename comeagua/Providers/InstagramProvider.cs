using InstagramLogin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using InstagramNet.Service.Extensions;
using System.IO;
namespace InstagramLogin.Providers
{
    public class InstagramProvider
    {
        public string ClientId;
        public string ClientSecret;
        public string RedirectUri;
        public string AccessToken;
        private List<InstagramPost> posts = new List<InstagramPost>();

        public InstagramProvider(string ClientId, string ClientSecret, string RedirectUri, string AccessToken = "")
        {
            this.ClientId = ClientId;
            this.ClientSecret = ClientSecret;
            this.RedirectUri = RedirectUri;
            this.AccessToken = AccessToken;
        }

        private string Request(string url)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var response = wc.DownloadString(url);
            return response;
        }

        public string Post(string url, string data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.instagram.com/oauth/access_token");
            request.Method = "POST";
            request.Accept = "application/json";
            request.UserAgent = "curl/7.37.0";
            request.ContentType = "application/x-www-form-urlencoded";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var response = request.GetResponse();
            string text;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            return text;
        }

        public string GenerateAuthenticateUrl()
        {
            return "https://instagram.com/oauth/authorize/?client_id=" + ClientId + "&redirect_uri=" + RedirectUri + "&response_type=code";
        }

        public InstagramAuthenticateModel Authenticate(string code)
        {
            var url = "https://api.instagram.com/oauth/access_token";
            var data = "client_id=" + ClientId + "&client_secret=" + ClientSecret + "&grant_type=authorization_code&redirect_uri=" + RedirectUri + "&code=" + code;
            var result = Post(url, data);

            var model = JsonConvert.DeserializeObject<InstagramAuthenticateModel>(result);
            AccessToken = model.access_token;

            return model;
        }

        public List<InstagramPost> GetUserPhotos(string userId, DateTime start, string nextPage = "")
        {
            try
            {
               var url = "https://api.instagram.com/v1/users/" + userId + "/media/recent?min_timestamp=" + start.ToUnixTimestamp() + "&access_token=" + AccessToken;
                if (!string.IsNullOrEmpty(nextPage))
                {
                    url = nextPage;
                }
              var response = Request(url);
                var model = JsonConvert.DeserializeObject<InstagramPostListModel>(response);
                posts.AddRange(model.data);

               if (!string.IsNullOrEmpty(model.pagination.next_url))
                {
                    GetUserPhotos(userId, start, model.pagination.next_url);
                }

                return posts;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public InstagramUserData GetUserData(string userId)
        {
            try
            {
                var url = "https://api.instagram.com/v1/users/" + userId + "?access_token=" + AccessToken;

                var response = Request(url);
                var model = JsonConvert.DeserializeObject<InstagramUserData>(response);
                return model;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

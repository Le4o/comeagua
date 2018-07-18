using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace comeagua.Controllers
{
    public partial class ControllerLoginInstagram: System.Web.UI.Page
    {
        static string code = string.Empty;
        protected void page_load(object sender,EventArgs e)
        {
            if(!String.IsNullOrEmpty(Request["code"]) && !Page.IsPostBack){
                code = Request["code"].ToString();
                GetDataInstagramToken();
            }
        }
        public void GetDataInstagramToken()
        {
            var json = "";
            try
            {
                NameValueCollection parameters = new NameValueCollection();
                parameters.Add("client_id", ConfigurationManager.AppSettings["ClientId"].ToString());
                parameters.Add("client_secret", ConfigurationManager.AppSettings["ClientSecret"].ToString());
                parameters.Add("grant_type","authorization_code");
                parameters.Add("redirect_uri", ConfigurationManager.AppSettings["RedirectURI"].ToString());
                parameters.Add("code", code);
                WebClient client = new WebClient();
                var result = client.UploadValues("https://api.instagram.com/oauth/access_token", "POST", parameters);
                var response = System.Text.Encoding.Default.GetString(result);
                var jsResult = (JObject)JsonConvert.DeserializeObject(response);
                string accessToken = (string)jsResult["access_token"];
                // int id = (int) jsResult["user"]["id"];
                string imageurl = (string)jsResult["user"]["profile_picture"];
                string fullname = (string)jsResult["user"]["full_name"];
                lblusername.Text = fullname;
                ProfilePic.ImageUrl = imageurl;             
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
        
    }
}
using InstagramLogin.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstagramLogin.Controllers
{
    public class HomeController : Controller
    {
        InstagramProvider instagramprovider;
        public HomeController()
        {
            var clientId = "your applicaiton clientId";
            var clientSecret = "your application client secret";
            var callBackUrl = "http://localhost:53137/Home/InstagramCallBack";
            instagramprovider = new InstagramProvider(clientId, clientSecret, callBackUrl);
        }
        public ActionResult Index()
        {
            return View();
        }
        //Redireciona para o site
        public ActionResult InstagramLogin()
        {
            return Redirect(instagramprovider.GenerateAuthenticateUrl());
        }

        public ActionResult InstagramCallBack(string code)
        {
            var authanticaonData = instagramprovider.Authenticate(code);

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}
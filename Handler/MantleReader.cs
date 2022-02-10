using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MantleRPC.Handler
{
    internal class MantleReader
    {
        /// <summary>
        /// Since there is no web json file for Mantle.gg containing user data, I will just get cape data based upon website html :p
        /// Forgot about the user not being logged in on the webclient it creates. So I will use their cookie to log in
        /// As of now, this is not done. Will probably make a cookie grabber to log in so I can get the string using the users account for this to work
        /// </summary>

        public static string[] CapeArr = new string[] {};

        public static void GetCapeData()
        {
            WebClient client = new WebClient();
            if (client.DownloadString("https://mantle.gg/account").Contains("Black"))
            {
                CapeArr.Append("Black Cape");
            }
            if (client.DownloadString("https://mantle.gg/account").Contains("NameMC Vote"))
            {
                CapeArr.Append("NameMC Cape");
            }
        }
    }
}

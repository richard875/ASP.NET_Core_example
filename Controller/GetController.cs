using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebAPI
{
    public class GetController : ControllerBase
    {
        public GetController() {}

        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }

        public string Xamarin(string name)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, welcome to Visual Studio for Mac");
        }
    }
}

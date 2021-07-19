using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebAPI
{
    public class DataController : ControllerBase
    {
        public string GetDataTestOne(string name)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, you are getting the first set of test data");
        }
    }
}

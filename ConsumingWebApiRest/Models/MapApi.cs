using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumingWebApiRest.Models
{
    //https://thecodehubs.com/consuming-rest-api-from-controller-in-asp-net-mvc/ guia
    public class MapApi
    {
        public string Name { get; set; }
        public string Month { get; set; }
        public string Sales_Figure { get; set; }
        public string Perc { get; set; }
    }
}
using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorWebApi.ComOrder
{
    public class CalendarBase : ComponentBase
    {
        private readonly HttpClient Http;

        public CalendarBase()
        {
        }

        public CalendarBase(HttpClient httpClient) : this()
        {
            Http = httpClient;
        }
    }
}
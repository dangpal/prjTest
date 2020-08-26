using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorWebApi.Pages.Order
{
    public class OrderListBase : ComponentBase
    {
        private readonly HttpClient Http;
        protected string strTestMsg { get; set; }

        public OrderListBase()
        {
        }

        public OrderListBase(HttpClient httpClient) : this()
        {
            Http = httpClient;
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            this.strTestMsg = Common.ClsUtility.strTest;
        }

    }
}
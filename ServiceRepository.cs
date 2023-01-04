﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MVC_HotelManagement.Repository
{
    public class ServiceRepository
    {
        HttpClient client;
        public ServiceRepository()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["apiBaseURL"].ToString());
        }
        public HttpResponseMessage GetResponse(string url)
        {
            return client.GetAsync(url).Result;
        }
        public HttpResponseMessage PostResponse(string url, object content)
        {
            return client.PostAsJsonAsync(url, content).Result;
        }
        public HttpResponseMessage DeleteResponse(string url, int Id)
        {
            return client.DeleteAsync(url + Id.ToString()).Result;
        }
        public HttpResponseMessage VerifyLogin(string url, object model)
        {
            return client.PostAsJsonAsync(url, model).Result;
        }

        internal IDisposable DeleteResponse(string v, string phno)
        {
            throw new NotImplementedException();
        }
    }
}
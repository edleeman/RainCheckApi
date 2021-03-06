﻿using System.Net.Http;
using System.Threading.Tasks;

namespace RainCheck.Intefaces
{
    public interface IHttpClient
    {
        /// <summary>
        /// The method to use when making an HTTP request.
        /// </summary>
        /// <param name="requestString">The full URL to make the request to.</param>
        /// <returns>The response from <paramref name="requestString"/></returns>
        Task<HttpResponseMessage> HttpRequest(string requestString);
    }
}

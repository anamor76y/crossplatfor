using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json.Linq;

namespace Lab5.Services
{
    public class Lab6APIService
    {
        private readonly HttpClient _httpClient;
        private readonly Auth0UserService _auth0UserService;

        public Lab6APIService(HttpClient httpClient, Auth0UserService auth0UserService)
        {
            _httpClient = httpClient;
            _auth0UserService = auth0UserService;
        }

        private async Task SetAuthorizationHeaderAsync()
        {
            var accessToken = await _auth0UserService.GetApiTokenAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }
    }
}
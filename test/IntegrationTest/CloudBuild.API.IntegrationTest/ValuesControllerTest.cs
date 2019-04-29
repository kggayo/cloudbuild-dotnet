using System;
using System.Net.Http;
using Xunit;

namespace CloudBuild.API.IntegrationTest
{
    public class ValuesControllerTest
    {
        private string baseUrl = "http://api:5000";

        [Fact]
        public async void Get_Values_Id()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(baseUrl + "/api/values/1");

            var jsonString = await result.Content.ReadAsStringAsync();
            Assert.Equal("value: 1", jsonString, true);
        }
    }
}

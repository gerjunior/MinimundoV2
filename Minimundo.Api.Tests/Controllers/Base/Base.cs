using FluentAssertions;
using RestSharp;
using Xunit;

namespace Minimundo.Api.Tests.Controllers
{
    public abstract class Base
    {
        private readonly string _item;
        private static string Url;

        protected Base(string item)
        {
            _item = item;
            Url = "https://localhost:44332/" + _item;
        }

        [Fact]
        protected void GetAll()
        {
            var response = Get("");
            response.StatusCode.Should().Be(200);
        }

        [Fact]
        protected void GetNone()
        {
            var response = Get("0");
            response.StatusCode.Should().Be(404);
        }

        protected IRestResponse Get(string ID = "")
        {
            var client = new RestClient($"{Url}/{ID}");
            var request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };

            return client.Execute(request);
        }
    }
}

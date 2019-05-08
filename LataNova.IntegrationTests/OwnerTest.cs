using Application.Factories;
using Core.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LataNova.IntegrationTests
{
    public class OwnerTest
    {
        private const string url = "https://localhost:44394/api/Owner";
        private HttpClient client;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task WhenRequestOwnerControllerUsingGet_ThenICanReadTheResponseContent()
        {
            // Arrange
            client = new HttpClient();

            // Act
            var response = await client.GetAsync($"{url}");
            var apiResponse = JsonConvert.DeserializeObject<Owner[]>(await response.Content.ReadAsStringAsync());

            // Assert
            Assert.NotNull(apiResponse);
        }

        [Test]
        public async Task WhenRequestOwnerControllerUsingPost_ThenICheckIfOwnerWasAdded()
        {
            // Arrange
            var name = "Owner 01";
            var cpf = "CPF 01";
            var gender = 'M';
            var birthdate = DateTime.Now;
            var owner = Factories.Owner.Create(name, cpf, gender, birthdate);
            client = new HttpClient();
            var test = JsonConvert.SerializeObject(owner);

            // Act
            var response = await client.PostAsync($"{url}",
                new StringContent(JsonConvert.SerializeObject(owner), Encoding.UTF8, "application/json"));
            

            // Assert
            //Assert.NotNull(apiResponse);
        }
    }
}
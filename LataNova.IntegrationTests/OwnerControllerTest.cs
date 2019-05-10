using Application.Factories;
using Core.Models;
using LataNova.IntegrationTests.Helpers;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LataNova.IntegrationTests
{
    public class OwnerControllerTest
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
        public async Task WhenRequestOwnerControllerUsingGetWithSpecificId_ThenIReceiveOwner()
        {
            // Arrange
            client = new HttpClient();
            var id = "A0D812FF-B7EB-4B08-822D-5EEA274C4EB2";

            // Act
            var response = await client.GetAsync($"{url}/{id}");
            var ownerReceived = JsonConvert.DeserializeObject<Owner>(await response.Content.ReadAsStringAsync());

            // Assert
            Assert.NotNull(ownerReceived);
            Assert.IsInstanceOf(typeof(Owner), ownerReceived);
        }

        [Test]
        public async Task WhenRequestOwnerControllerUsingPost_ThenICheckIfOwnerWasAdded()
        {
            // Arrange
            var owner = OwnerHelper.CreateRandomOwner();
            client = new HttpClient();
            
            // Act
            var response = await client.PostAsync($"{url}",
                new StringContent(JsonConvert.SerializeObject(owner), Encoding.UTF8, "application/json"));
            
            // Assert
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        }

        [Test]
        public async Task WhenRequestOwnerControllerusingPut_ThenICheckIfOwnerWasUpdated()
        {
            // Arrange
            client = new HttpClient();
            var id = "A0D812FF-B7EB-4B08-822D-5EEA274C4EB2";
            
            var ownerReceived = JsonConvert.DeserializeObject<Owner>(await (await client.GetAsync($"{url}/{id}")).Content.ReadAsStringAsync());
            var ownerNewValues = OwnerHelper.CreateRandomOwner();
            ownerNewValues.Id = ownerReceived.Id;

            // Act
            var response = await client.PutAsync($"{url}/{id}",
                new StringContent(JsonConvert.SerializeObject(ownerNewValues), Encoding.UTF8, "application/json"));

            // Assert
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.Equals(ownerNewValues,
                JsonConvert.DeserializeObject<Owner>(await response.Content.ReadAsStringAsync()));
        }

        [Test]
        public async Task WhenRequestOwnerControllerUsingPost_ThenVerifyIfOwnerWasCreatedUsingGetRequest_ThenISendDeleteRequestToOwnerController_ThenICantFindOwnerOnGet()
        {
            // Arrange
            var owner = OwnerHelper.CreateRandomOwner();

            client = new HttpClient();
            var insert_response = await client.PostAsync($"{url}",
                new StringContent(JsonConvert.SerializeObject(owner), Encoding.UTF8, "application/json"));
            var get_response = await client.GetAsync($"{url}/{owner.Id}");

            // Act
            var delete_response = await client.DeleteAsync($"{url}/{owner.Id}");
            get_response = await client.GetAsync($"{url}/{owner.Id}");

            var test = get_response.Content.ReadAsStringAsync();
            // Assert
            Assert.AreEqual(get_response.StatusCode, System.Net.HttpStatusCode.NoContent);
        }
    }
}
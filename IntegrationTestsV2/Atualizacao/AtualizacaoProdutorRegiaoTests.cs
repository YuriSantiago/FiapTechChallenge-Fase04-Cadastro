﻿using Core.Requests.Update;
using System.Net;
using System.Net.Http.Json;

namespace IntegrationTestsV2.Cadastro
{
    public class AtualizacaoProdutorRegiaoTests : IClassFixture<CustomWebApplicationFactory<AtualizacaoProdutor.Program>>
    {
        private readonly HttpClient _client;

        public AtualizacaoProdutorRegiaoTests(CustomWebApplicationFactory<AtualizacaoProdutor.Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Update_ShouldReturnOK_WhenContatoIsValid()
        {
            // Arrange
            var regiaoUpdateRequest = new RegiaoUpdateRequest
            {
                Id = 1,
                DDD = 11,
                Descricao = "São Paulo"
            };

            // Act
            var response = await _client.PutAsJsonAsync("/Regiao", regiaoUpdateRequest);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        //[Fact]
        //public async Task Update_ShouldReturnBadRequest_WhenIdDoesNotExist()
        //{
        //    // Arrange
        //    var regiaoUpdateRequest = new RegiaoUpdateRequest
        //    {
        //        Id = 9999,
        //        DDD = 11,
        //        Descricao = "São Paulo"
        //    };

        //    // Act
        //    var response = await _client.PutAsJsonAsync("/Regiao", regiaoUpdateRequest);

        //    // Assert
        //    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        //}

    }
}

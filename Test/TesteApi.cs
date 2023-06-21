using Microsoft.AspNetCore.Razor.Language.Extensions;
using NUnit.Framework;
using RestSharp;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Test
{
    //Feature de Teste
    [TestFixture, Parallelizable(ParallelScope.Fixtures)]
    public class TesteApi : TestBase
    {
        [Test]
        public void PegarToken()
        {
            //Arrange - Pre-condicao do teste
            RestResponse response;
            string url = "https://apicorp-qa.hml.unidas.com.br";
            string partialUrl = "/rfc-oauth/v1/token";
            string basic = "Basic Y2E3NjQ0MTYtMDE3NC00YzQxLWE0N2QtYTNjMjU5N2U2NmZiOjQ5OGVkNzIyLWNmMmItNDgwNy1iMTgzLTY3ZjhiN2Y1MGE2ZA==";


            // Cria os parâmetros
            var parametros = new CustomParameter[]
            {
                new CustomParameter("Authorization", basic, ParameterType.HttpHeader),
                new CustomParameter("Content-Type", "application/json", ParameterType.HttpHeader),
                new CustomParameter("application/json", "{ \"grant_type\": \"client_credentials\" }", ParameterType.RequestBody)
            };

            //Act - Acoes do teste
            response = GetReponse(url, partialUrl, Method.Post, parametros);

            //Assert - Validacao do teste
            Assert.IsNotNull(response);
            Assert.AreEqual(200, response.StatusCode);


        }
    }
}
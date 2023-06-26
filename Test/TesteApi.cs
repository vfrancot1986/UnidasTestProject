using NUnit.Framework;
using RestSharp;
using System.Net;
using UnidasTestProject.Model;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Test
{
    //Feature de Teste
    [TestFixture, Parallelizable(ParallelScope.Fixtures)]
    public class TesteApi : TestBase
    {
        [Test]
        public async Task PegarToken()
        {
            // Arrange - Pre-condicao do teste
            RestResponse<TokenResponse> response;
            string url = "https://apicorp-qa.hml.unidas.com.br";
            string partialUrl = "/rfc-oauth/v1/token";
            string basic = "Basic Y2E3NjQ0MTYtMDE3NC00YzQxLWE0N2QtYTNjMjU5N2U2NmZiOjQ5OGVkNzIyLWNmMmItNDgwNy1iMTgzLTY3ZjhiN2Y1MGE2ZA==";

            // Cria os parâmetros
            var parametros = new Parameter[]
            {
                Parameter.CreateParameter("Authorization", basic, ParameterType.HttpHeader),
                Parameter.CreateParameter("Content-Type", "application/json", ParameterType.HttpHeader),
                Parameter.CreateParameter("application/json", "{ \"grant_type\": \"client_credentials\" }", ParameterType.RequestBody)
            };

            // Act - Acoes do teste
            response = await GetResponse<TokenResponse>(url, partialUrl, Method.Post, parametros);

            // Assert - Validacao do teste
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response.Data);

            var token = response.Data.Access_token;
        }
    }
}
using NUnit.Framework;
using UnidasTestProject.Page;
using UnidasTestProject.Resource;
using UnidasTestProject.Settings;

namespace UnidasTestProject.Test
{
    public class FluxoCotacaoSF : TestBase
    {
        //TestCase
        [Test]
        public void TestFluxoCotacao()
        {
            //Arrange - Pré-condicao do teste
            PageLoginSF PageLoginSF = new PageLoginSF(_driver);
            PageInicioSF PageInicioSF = new PageInicioSF(_driver);
            PageContaSF PageContaSF = new PageContaSF(_driver);
            PageOportunidadeSF PageOportunidadeSF = new PageOportunidadeSF(_driver);

            string? _url = AppSettings.UrlQA;
            string? _usuario = AppSettings.UserQA;
            string? _senha = AppSettings.PasswordQA;

            //Act - Acoes do teste
            AbrirSF(_url);
            PageLoginSF.FazerLogin(_usuario, _senha);
            PageInicioSF.PesquisarConta();
            PageContaSF.NovaOportunidade();
            PageOportunidadeSF.CadNovaOportunidade();

            //Assert - Validacao do teste
            
        }
        //TestCase
        [Test]
        public void OportunidadeUsuarioSemInodadeNegocio()
        {
            //Arrange - Pré-condicao do teste
            PageLoginSF PageLoginSF = new PageLoginSF(_driver);
            PageInicioSF PageInicioSF = new PageInicioSF(_driver);
            PageContaSF PageContaSF = new PageContaSF(_driver);
            PageOportunidadeSF PageOportunidadeSF = new PageOportunidadeSF(_driver);

            string? _url = AppSettings.UrlQA;
            string? _usuario = AppSettings.UserQA;
            string? _senha = AppSettings.PasswordQA;

            //Act - Acoes do teste
            AbrirSF(_url);
            PageLoginSF.FazerLogin(_usuario, _senha);
            PageInicioSF.PesquisarConta();
            PageContaSF.NovaOportunidade();
            PageOportunidadeSF.CadNovaOportunidade();

            //Assert - Validacao do teste

            Assert.IsTrue(PageOportunidadeSF.ValidarMsgUsuarioNaoPossuiAreaNegocio());
        }
    }
}
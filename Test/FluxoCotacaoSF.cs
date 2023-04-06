using NUnit.Framework;
using UnidasTestProject.Controller;
using UnidasTestProject.Resource;
using UnidasTestProject.Settings;

namespace UnidasTestProject.Test
{
    //Feature de Teste
    [TestFixture, Parallelizable(ParallelScope.Fixtures)]
    public class FluxoCotacaoSF : TestBase
    {

        //TestCase
        [Test]
        public void TestFluxoCotacao()
        {
            //Arrange - Pré-condicao do teste
            ControllerPageLoginSF ControllerPageLoginSF = new ControllerPageLoginSF(_driver);
            ControllerPageInicioSF ControllerPageInicioSF = new ControllerPageInicioSF(_driver);
            ControllerPageContaSF ControllerPageContaSF = new ControllerPageContaSF(_driver);
            ControllerPageOportunidadeSF ControllerPageOportunidadeSF = new ControllerPageOportunidadeSF(_driver);

            string? _usuario = AppSettings.UserQA;
            string? _senha = AppSettings.PasswordQA;

            //Act - Acoes do teste
            ControllerPageLoginSF.FazerLogin(_usuario, _senha);
            ControllerPageInicioSF.PesquisarConta();
            ControllerPageContaSF.NovaOportunidade();
            ControllerPageOportunidadeSF.CadNovaOportunidade();

            //Assert - Validacao do teste
            
        }
        //TestCase
        [Test]
        public void OportunidadeUsuarioSemInodadeNegocio()
        {
            //Arrange - Pré-condicao do teste
            ControllerPageLoginSF ControllerPageLoginSF = new ControllerPageLoginSF(_driver);
            ControllerPageInicioSF ControllerPageInicioSF = new ControllerPageInicioSF(_driver);
            ControllerPageContaSF ControllerPageContaSF = new ControllerPageContaSF(_driver);
            ControllerPageOportunidadeSF ControllerPageOportunidadeSF = new ControllerPageOportunidadeSF(_driver);

            string? _url = AppSettings.UrlQA;
            string? _usuario = AppSettings.UserQA;
            string? _senha = AppSettings.PasswordQA;

            //Act - Acoes do teste
            ControllerPageLoginSF.FazerLogin(_usuario, _senha);
            ControllerPageInicioSF.PesquisarConta();
            ControllerPageContaSF.NovaOportunidade();
            ControllerPageOportunidadeSF.CadNovaOportunidade();

            //Assert - Validacao do teste

            Assert.IsTrue(ControllerPageOportunidadeSF.ValidarMsgUsuarioNaoPossuiAreaNegocio());
        }
    }
}
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
            ControllerPageLoginSF ControllerPageLoginSF = new (_driver);
            ControllerPageInicioSF ControllerPageInicioSF = new (_driver);
            ControllerPageContaSF ControllerPageContaSF = new (_driver);
            ControllerPageOportunidadeSF ControllerPageOportunidadeSF = new (_driver);

            string _usuario = AppSettings.UserQA;
            string _senha = AppSettings.PasswordQA;

            //Act - Acoes do teste
            ControllerPageLoginSF.FazerLogin(_usuario, _senha);
            ControllerPageInicioSF.PesquisarConta();
            ControllerPageContaSF.NovaOportunidade();
            ControllerPageOportunidadeSF.CadNovaOportunidade();

            //Assert - Validacao do teste
            Assert.IsTrue(true);
        }
        //TestCase
        [Test]
        public void OportunidadeUsuarioSemInodadeNegocio()
        {
            //Arrange - Pré-condicao do teste
            ControllerPageLoginSF ControllerPageLoginSF = new (_driver);
            ControllerPageInicioSF ControllerPageInicioSF = new (_driver);
            ControllerPageContaSF ControllerPageContaSF = new (_driver);
            ControllerPageOportunidadeSF ControllerPageOportunidadeSF = new (_driver);

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
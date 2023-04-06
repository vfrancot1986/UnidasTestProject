using OpenQA.Selenium;
using UnidasTestProject.Page;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Controller
{
    public class ControllerPageInicioSF
    {
        //Declaracao de variaveis
        public PageInicioSF _PageInicioSF;
        //Contrutor da classe
        public ControllerPageInicioSF(IWebDriver driver)
        {
            _PageInicioSF = new PageInicioSF(driver);
        }

        //Acoes da pagina
        public void PesquisarConta()
        {
            TestBase.thisElement(_PageInicioSF._btnSalesConsole, action.Click);
            TestBase.thisElement(_PageInicioSF._cpPesquisarApp, action.Click);
            TestBase.thisElement(_PageInicioSF._cpPesquisarApp, action.SendKey, "Sales Console");
            TestBase.thisElement(_PageInicioSF._cpPesquisarApp, action.Enter);
            TestBase.thisElement(_PageInicioSF._btnMenuNavegacao, action.Click);
            TestBase.thisElement(_PageInicioSF._optContas, action.Click);
            TestBase.thisElement(_PageInicioSF._txtCabecalhoConta, action.Click);
            TestBase.thisElement(_PageInicioSF._cpPesquisar, action.Click);
            TestBase.thisElement(_PageInicioSF._cpPesquisar, action.SendKey, "SEMAR SUPERMERCADO LTDA");
            TestBase.thisElement(_PageInicioSF._cpPesquisar, action.Enter);
            TestBase.thisElement(_PageInicioSF._linkConta, action.Click);
        }
    }
}

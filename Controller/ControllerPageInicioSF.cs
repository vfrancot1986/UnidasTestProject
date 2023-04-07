using OpenQA.Selenium;
using UnidasTestProject.Page;
using static UnidasTestProject.Resource.TestBase;
using Action = UnidasTestProject.Resource.TestBase.Action;

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
            ThisElement(_PageInicioSF._btnSalesConsole, Action.Click);
            ThisElement(_PageInicioSF._cpPesquisarApp, Action.Click);
            ThisElement(_PageInicioSF._cpPesquisarApp, Action.SendKey, "Sales Console");
            ThisElement(_PageInicioSF._cpPesquisarApp, Action.Enter);
            ThisElement(_PageInicioSF._btnMenuNavegacao, Action.Click);
            ThisElement(_PageInicioSF._optContas, Action.Click);
            ThisElement(_PageInicioSF._txtCabecalhoConta, Action.Click);
            ThisElement(_PageInicioSF._cpPesquisar, Action.Click);
            ThisElement(_PageInicioSF._cpPesquisar, Action.SendKey, "SEMAR SUPERMERCADO LTDA");
            ThisElement(_PageInicioSF._cpPesquisar, Action.Enter);
            ThisElement(_PageInicioSF._linkConta, Action.Click);
        }
    }
}

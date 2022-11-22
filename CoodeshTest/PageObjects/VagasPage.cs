using OpenQA.Selenium;
using System.Threading;

namespace CoodeshTest.PageObjects
{
    public class VagasPage
    {
        private IWebDriver driver;
        private By byVerVagas;
        private By byPesquisarVagas;
        private By byBtnBuscar;

        public VagasPage(IWebDriver driver)
        {
            this.driver = driver;
            byVerVagas = By.LinkText("Ver Vagas");
            byPesquisarVagas = By.XPath("//main[@id='content']/div/div/form/div/div/div/input");
            byBtnBuscar = By.XPath("//button[@type='submit']");
        }

        public void Pesquisar(string nome)
        {
            driver.FindElement(byVerVagas).Click();
            Thread.Sleep(1000);
            driver.FindElement(byPesquisarVagas).SendKeys(nome);
            driver.FindElement(byBtnBuscar).Click();
        }
    }
}

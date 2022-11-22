using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace CoodeshTest.PageObjects
{
    public class ScoreCardPage
    {
        private IWebDriver driver;
        private By byBtnProximo;
        private By byBtnFinalizar;
        private By byUnitTest;
        private By byConfirmar;
        private By byUltimoBtnProximo;
        private By bySelecionanadoHabilidade;

        public ScoreCardPage(IWebDriver driver)
        {
            this.driver = driver;
            byBtnProximo = By.XPath("//div[@id='footer-portal']/div/div/button[2]");
            byBtnFinalizar = By.XPath("//button[@type='submit']");
            byUnitTest = By.XPath("/html/body/div[1]/div[3]/div/div/form/table/tbody/tr[1]/td/div/div[3]/span[3]");
            byConfirmar = By.LinkText("Concluir");
            byUltimoBtnProximo = By.XPath("/html/body/div[1]/div[4]/div/div/div/div/button[2]");
            bySelecionanadoHabilidade = By.XPath("/html/body/div[1]/div[3]/div/div/form/table/tbody/tr[3]/td/div/div[4]");
        }

        public void Avancar()
        {
            Thread.Sleep(1000);
            driver.FindElement(byBtnProximo).Click();
            Thread.Sleep(1000);
            driver.FindElement(byBtnProximo).Click();
            Thread.Sleep(1000);
            driver.FindElement(byBtnProximo).Click();
            Thread.Sleep(0900);
            driver.FindElement(byBtnProximo).Click();
            Thread.Sleep(1500);
            driver.FindElement(byUltimoBtnProximo).Click();
            Thread.Sleep(1500);
            driver.FindElement(bySelecionanadoHabilidade).Click();
            driver.FindElement(byUnitTest).Click();
            driver.FindElement(byBtnFinalizar).Click();
            Thread.Sleep(1000);
            driver.FindElement(byConfirmar).Click();
        }
    }
}

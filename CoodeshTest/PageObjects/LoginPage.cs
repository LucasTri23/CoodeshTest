using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace CoodeshTest.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;
        private By byLogin;
        private By byEmial;
        private By bySenha;
        private By byBtnEntrar;
        private By byVagas;
        private By byPesquisarVagas;
        private By byBtnPesquisarVagas;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            byLogin = By.LinkText("Login");
            byEmial = By.Id("email");
            bySenha = By.Id("password");
            byBtnEntrar = By.XPath("/html/body/div[1]/main/main/div/div/div/div/form/div[3]/div/div[2]/button");
            byVagas = By.LinkText("Ver Vagas");
            byPesquisarVagas = By.XPath("/html/body/div[1]/main/div/div[1]/form/div/div[1]/div/input");
            byBtnPesquisarVagas = By.XPath("/html/body/div[1]/main/div/div[1]/form/div/div[3]/button");

        }

        public void Login(string email, string senha)
        {
            driver.FindElement(byLogin).Click();
            driver.FindElement(byEmial).SendKeys(email);
            driver.FindElement(bySenha).SendKeys(senha);
            driver.FindElement(byBtnEntrar).Click();
            Thread.Sleep(2000);
        }

        public void AcessarVagas(string vagasEmpresa)
        {
            Thread.Sleep(2000);
            driver.FindElement(byVagas).Click();
            driver.FindElement(byPesquisarVagas).SendKeys(vagasEmpresa + Keys.Enter);
            driver.FindElement(byBtnPesquisarVagas).Click();
            Thread.Sleep(2000);
        }
    }
}

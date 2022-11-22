using CoodeshTest.PageObjects;
using OpenQA.Selenium;
using PriceMachine.Automation.Fixtures;
using System.Threading;
using Xunit;

namespace PriceMachine.Automation.Testes
{
    [Collection("Chrome Driver")]
    public class UITestes
    {
        private IWebDriver driver;

        //Setup
        public UITestes(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void AcessarCoodesh()
        {
            //arrange
            var criar = new CriarContaPage(driver);

            //act
            criar.AcessarPagina();
            criar.CriarConta("Felicia Carroll", "felicia.carroll@testing.com", "Brasil616@");
            var onboarding = new OnboradingPage(driver);
            onboarding.Carreiras();
            //onboarding.Habilidades("Agile");
            onboarding.FinalizarOnborading(31995632158, "Belo Horizonte");
            onboarding.Proximo();
            var onboardingComunidade = new OnboardingComunidadesPage(driver);
            onboardingComunidade.OnboradingDois("Saúde");
            onboardingComunidade.Proximo();
            onboardingComunidade.ScoreCard();
            Assert.Contains("ScoreCard", driver.PageSource);
            var ScoreCard = new ScoreCardPage(driver);
            ScoreCard.Avancar();

            //assert
            Assert.Contains("Currículo | Coodesh", driver.Title);
        }

        [Fact]
        public void AcessarVagas()
        {
            //arrange
            var criar = new CriarContaPage(driver);

            //act
            criar.AcessarPagina();
            var login = new LoginPage(driver);
            login.Login("felicia.carroll@testing.com", "Brasil616@");
            Assert.Contains("Meu Perfil", driver.PageSource);

            login.AcessarVagas("space force corporações");
        }


    }
}
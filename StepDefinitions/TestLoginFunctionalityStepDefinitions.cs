using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestLoginFunctionalityStepDefinitions
    {
        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            Console.WriteLine("Test: User is on the Login Page");
        }

        [When(@"User enters username and password")]
        public void WhenUserEntersUsernameAndPassword()
        {
            Console.WriteLine("Test: User enters username and password");
        }

        [When(@"User clicks login button")]
        public void WhenUserClicksLoginButton()
        {
            Console.WriteLine("Test: User clicks login button");
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("Test: User is navigated to home page");
        }
    }
}

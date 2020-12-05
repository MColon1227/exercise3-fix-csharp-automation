using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace exercise3_fix_csharp_automation.Steps
{
  [Binding]
  public sealed class LoginSteps
  {
    [Given(@"I have to navigate to the Amazon page")]
    public void GivenIHaveToNavigateToTheAmazonPage()
    {
      ScenarioContext.Current.Pending();
    }

    [Given(@"I enter username")]
    public void GivenIEnterUsername(Table table)
    {
      ScenarioContext.Current.Pending();
    }

    [Given(@"I click the continue button")]
    public void GivenIClickTheContinueButton()
    {
      ScenarioContext.Current.Pending();
    }

    [Given(@"I enter the password")]
    public void GivenIEnterThePassword(Table table)
    {
      ScenarioContext.Current.Pending();
    }

    [Then(@"I click the login button")]
    public void ThenIClickTheLoginButton()
    {
      ScenarioContext.Current.Pending();
    }

    [Then(@"I search for product: Samsung Galaxy S9 64GB")]
    public void ThenISearchForProductSamsungGalaxySGB()
    {
      ScenarioContext.Current.Pending();
    }

    [Then(@"I Select first product and save the price And Click on the product")]
    public void ThenISelectFirstProductAndSaveThePriceAndClickOnTheProduct()
    {
      ScenarioContext.Current.Pending();
    }

    [Then(@"I Validate that the Shop car has (.*) as a number")]
    public void ThenIValidateThatTheShopCarHasAsANumber(int p0)
    {
      ScenarioContext.Current.Pending();
    }

    [Then(@"I Search for another product: Alienware Aw3418DW")]
    public void ThenISearchForAnotherProductAlienwareAwDW()
    {
      ScenarioContext.Current.Pending();
    }

    [Then(@"I Select First product And Add to Cart")]
    public void ThenISelectFirstProductAndAddToCart()
    {
      ScenarioContext.Current.Pending();
    }

    [Then(@"I Verify that the cart number is now (.*)")]
    public void ThenIVerifyThatTheCartNumberIsNow(int p0)
    {
      ScenarioContext.Current.Pending();
    }
  }
}

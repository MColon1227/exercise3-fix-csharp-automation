using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace exercise3_fix_csharp_automation.Steps
{
  [Binding]
  public class LoginSteps : PageObject
  {

    [Given(@"I have to navigate to the Amazon page")]
    public void GivenIHaveToNavigateToTheAmazonPage()
    {
      Console.WriteLine("Start working on mi chingadera I have to navigate to the Amazon page");
      driver.Navigate().GoToUrl(BASE_URL);
    }

    [Given(@"I enter username")]
    public void GivenIEnterUsername(Table table)
    {
      WaitHandle();
      Console.WriteLine("I enter username");
      identifyAccount();
      Console.WriteLine(ConfigurationManager.AppSettings.Get("username"));
      enterEmail("marisolcolon1227@gmail.com");
    }

    [Given(@"I click the continue button")]
    public void GivenIClickTheContinueButton()
    {
      WaitHandle();
      Console.WriteLine("I click the continue button");
      presscontinuebuttonemail();
    }

    [Given(@"I enter the password")]
    public void GivenIEnterThePassword(Table table)
    {
      WaitHandle();
      Console.WriteLine("I enter the password");
      Console.WriteLine(ConfigurationManager.AppSettings.Get("password"));
      enterpassword("amazonTesting!!");
    }

    [Then(@"I click the login button")]
    public void ThenIClickTheLoginButton()
    {
      WaitHandle();
      Console.WriteLine("I click the login button");
      presssubmitbutton();
    }

    [Then(@"I search for product: Samsung Galaxy S9 64GB")]
    public void ThenISearchForProductSamsungGalaxySGB()
    {
      WaitHandle();
      Console.WriteLine("I search for product: Samsung Galaxy S9 64GB");
      searchinput("Samsung Galaxy S9 64GB");
      presssearchinputbutton();
    }

    [Then(@"I Select first product and save the price And Click on the product")]
    public void ThenISelectFirstProductAndSaveThePriceAndClickOnTheProduct()
    {
      WaitHandle();
      Console.WriteLine("I Select first product and save the price And Click on the product");
      string savedPriceCss = savedprice();
      savedPriceClick();

      WaitHandle();
      Console.WriteLine("I Validate first price vs detail price");
      string detailPriceCss = detailprice();
      actualpriceresult();
      Assert.AreEqual(savedPriceCss, detailPriceCss);

      Console.WriteLine("I Click on Add to Cart");
      WaitHandle();
      addToCart();

      Console.WriteLine("I Validate again, first price vs current price");
      WaitHandle();
      string savedActualPrice = actualPrice();
      Assert.AreEqual(detailPriceCss, savedActualPrice);

    
    }

    [Then(@"I Validate that the Shop car has (.*) as a number")]
    public void ThenIValidateThatTheShopCarHasAsANumber(int p0)
    {
      WaitHandle();
      Console.WriteLine("I Validate that the Shop car has (.*) as a number");
      string savedShopCart = shopCart();
      Assert.AreEqual(savedShopCart, "1");
      
    }

    [Then(@"I Search for another product: Alienware Aw3418DW")]
    public void ThenISearchForAnotherProductAlienwareAwDW()
    {
      WaitHandle();
      Console.WriteLine("I Search for another product: Alienware Aw3418DW");
      searchinput("Alienware Aw3418DW");
      presssearchinputbutton();
    }

    [Then(@"I Select First product And Add to Cart")]
    public void ThenISelectFirstProductAndAddToCart()
    {
      WaitHandle();
      Console.WriteLine("I Select First product And Add to Cart");
      clickFirstProduct();
      addToCart();
    }

    [Then(@"I Verify that the cart number is now (.*)")]
    public void ThenIVerifyThatTheCartNumberIsNow(int p0)
    {
      WaitHandle();
      Console.WriteLine("I Verify that the cart number is now (.*)");
      string savedShopCart2 = shopCart();
      Assert.AreEqual(savedShopCart2, "2");
    }

    //[AfterScenario]
    //public void CleanUp()
    //{
    //  driver.Close();
    //}
  }
}

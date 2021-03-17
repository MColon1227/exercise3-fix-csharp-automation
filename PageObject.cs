using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace exercise3_fix_csharp_automation
{
  public class PageObject
  {
    private const string NewValue = "";
    public static string BASE_URL = "https://www.amazon.com.mx/";
    public static string CHROME_DRIVER_LOCATION = @"C:\Users\marisol.colon\Downloads\chromedriver_win32";

    public IWebDriver driver;

    public PageObject()
    {
      driver = new ChromeDriver(CHROME_DRIVER_LOCATION);
    }

    public IWebElement identify => driver.FindElement(By.CssSelector("a#nav-link-accountList"));
    public IWebElement inputEmail => driver.FindElement(By.CssSelector("input#ap_email"));
    public IWebElement continueEmail => driver.FindElement(By.CssSelector("input#continue"));
    public IWebElement passwordCss => driver.FindElement(By.CssSelector("input#ap_password"));
    public IWebElement submitButton => driver.FindElement(By.CssSelector("input#signInSubmit"));
    public IWebElement searchInputOption => driver.FindElement(By.CssSelector("input#twotabsearchtextbox"));
    public IWebElement searchButton => driver.FindElement(By.CssSelector("span#nav-search-submit-text > .nav-input"));
    public IWebElement savedPriceCss => driver.FindElement(By.XPath("//div[4]/div[@class='sg-col-inner']//span[@class='a-price']"));
    public IWebElement clickSavedPrice => driver.FindElement(By.CssSelector("div.s-result-list.s-main-slot > div:nth-child(4) img"));
    public IWebElement detailPriceCss => driver.FindElement(By.CssSelector("span#price_inside_buybox"));
    public IWebElement addToCartCss => driver.FindElement(By.CssSelector("input#add-to-cart-button"));
    public IWebElement actualPriceCss => driver.FindElement(By.CssSelector("#hlb-subcart .a-color-price"));
    public IWebElement shopCartCss => driver.FindElement(By.CssSelector("span#nav-cart-count"));
    public IWebElement clickFirstProductCss => driver.FindElement(By.CssSelector(".s-main-slot.s-result-list.s-search-results.sg-row > div:nth-of-type(2) > .sg-col-inner"));

    public void WaitHandle()
    {
      try
      {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        Console.WriteLine("Test pass");
      }
      catch (Exception e)
      {
        Console.WriteLine("Test pass", e);
      }
    }

    public void identifyAccount() => identify.Click();

    public void enterEmail(string username)
    {
      inputEmail.SendKeys(username);
    }

    public void presscontinuebuttonemail() => continueEmail.Click();

    public void enterpassword(string password)
    {
      passwordCss.SendKeys(password);
    }

    public void presssubmitbutton() => submitButton.Click();

    public void searchinput(string search_product) => searchInputOption.SendKeys(search_product);

    public void presssearchinputbutton() => searchButton.Click();

    public string savedprice()
    {
      string price = savedPriceCss.Text.Replace("\n", NewValue).Replace("\r", "");
      return addChar(price, ".", price.Length - 2);
    }

    public void savedPriceClick() => clickSavedPrice.Click();

    public string detailprice() => detailPriceCss.Text;

    public bool actualpriceresult() => detailPriceCss.Displayed;

    public string addChar(string str, string ch, int position)
    {
      StringBuilder sb = new StringBuilder(str);
      sb.Insert(position, ch);
      return sb.ToString();
    }

    public void addToCart() => addToCartCss.Click();

    public String actualPrice() => actualPriceCss.Text;

    public String shopCart() => shopCartCss.Text;

    public void clickFirstProduct() => clickFirstProductCss.Click();
  }
}

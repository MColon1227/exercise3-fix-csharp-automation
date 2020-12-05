using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace exercise3_fix_csharp_automation
{
  public class PageObject
  {
    public IWebDriver WebDriver { get; }
    public PageObject(IWebDriver webDriver)
    {
      WebDriver = webDriver;
    }
    //IWebDriver driver;

    public IWebElement identify => WebDriver.FindElement(By.CssSelector("nav-link-accountList"));
    public IWebElement inputEmail => WebDriver.FindElement(By.CssSelector("input#ap_email"));
    public IWebElement continueEmail => WebDriver.FindElement(By.CssSelector("input#continue"));
    public IWebElement passwordCss => WebDriver.FindElement(By.CssSelector("input#ap_password"));
    public IWebElement submitButton => WebDriver.FindElement(By.CssSelector("input#signInSubmit"));
    public IWebElement searchInputOption => WebDriver.FindElement(By.CssSelector("input#twotabsearchtextbox"));
    public IWebElement searchButton => WebDriver.FindElement(By.CssSelector("span#nav-search-submit-text > .nav-input"));
    public IWebElement savedPriceCss => WebDriver.FindElement(By.XPath("//div[4]/div[@class='sg-col-inner']//span[@class='a-price']"));
    public IWebElement clickSavedPrice => WebDriver.FindElement(By.CssSelector("div.s-result-list.s-main-slot > div:nth-child(4) img"));
    public IWebElement detailPriceCss => WebDriver.FindElement(By.CssSelector("span#price_inside_buybox"));
    public IWebElement addToCartCss => WebDriver.FindElement(By.CssSelector("input#add-to-cart-button"));
    public IWebElement actualPriceCss => WebDriver.FindElement(By.CssSelector("#hlb-subcart .a-color-price"));
    public IWebElement shopCartCss => WebDriver.FindElement(By.CssSelector("span#nav-cart-count"));
    public IWebElement clickFirstProductCss => WebDriver.FindElement(By.CssSelector(".s-main-slot.s-result-list.s-search-results.sg-row > div:nth-of-type(1) > .sg-col-inner"));


    //public PageObject(IWebDriver driver)
    //{
    //  this.driver = driver;
    //  PageFactory.initElements(driver, this);
    //}
    public void identifyAccount() => identify.Click();

    public void enterEmail(String username) => inputEmail.SendKeys(username);

    public void presscontinuebuttonemail() => continueEmail.Click();

    public void enterpassword(string password) => passwordCss.SendKeys(password);

    public void presssubmitbutton() => submitButton.Click();

    public void searchinput(string search_product) => searchInputOption.SendKeys(search_product);

    public void presssearchinputbutton() => searchButton.Click();

    public string savedprice()
    {
      string price = (savedPriceCss).Text.Replace("\n", "");
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

// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class CarInsuranceRateTestsTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new FirefoxDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void carInsuranceRateAgeAs15VerifyAgeValidationError() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(804, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber ");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("15");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("2");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(1)")).Click();
    Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 16."));
  }
  [Test]
  public void carInsuranceRateAllValidInputsVerifyCorrectAge() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(804, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("age")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("25"));
    }
  }
  [Test]
  public void carInsuranceRateInvalidEmailAddressVerifyEmailAddressValidationError() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(871, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).SendKeys("teena");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("28");
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector(".col-md-8")).Click();
    Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
  }
  [Test]
  public void carInsuranceRateInvalidPhoneNumberVerifyPhoneNumberValidationError() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(748, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("123 123 1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("27");
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.Id("phone-error")).Click();
    driver.FindElement(By.Id("phone-error")).Click();
    driver.FindElement(By.Id("phone-error")).Click();
    Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
  }
  [Test]
  public void carInsuranceRateInvalidPostalCodeVerifyPostalCodeValidationError() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(871, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N221E8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.CssSelector(".card:nth-child(1) > .card-header")).Click();
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("35");
    driver.FindElement(By.Id("experience")).SendKeys("17");
    driver.FindElement(By.Id("accidents")).SendKeys("1");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.Id("postalCode-error")).Click();
    Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
  }
  [Test]
  public void carInsuranceRateNumberOfAtFaultAccidentsAs1VerifyNumberOfAtFaultAccidentsValidationError() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(804, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("27");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("-1");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(3)")).Click();
    driver.FindElement(By.CssSelector(".card-body")).Click();
    Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 0."));
  }
  [Test]
  public void carInsuranceRateOmitAddressVerifyValidationErrorOnAddress() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(804, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("5");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
    Assert.That(driver.FindElement(By.Id("address-error")).Text, Is.EqualTo("Address is required"));
  }
  [Test]
  public void carInsuranceRateOmitAgeVerifyValidationErrorOnAge() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(871, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).SendKeys("t");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("5");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.CssSelector(".card-body")).Click();
    Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
  }
  [Test]
  public void carInsuranceRateOmitCityVerifyValidationErrorOnCity() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(804, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector(".col-md-6")).Click();
    Assert.That(driver.FindElement(By.Id("city-error")).Text, Is.EqualTo("City is required"));
  }
  [Test]
  public void carInsuranceRateOmitFirstNameVerifyValidationErrorOnFirstName() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(844, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("lastName")).Click();
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber Street");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector("body")).Click();
    driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
    Assert.That(driver.FindElement(By.Id("firstName-error")).Text, Is.EqualTo("First Name is required"));
  }
  [Test]
  public void carInsuranceRateOmitLastNameVerifyValidationErrorOnLastName() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(844, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("26");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
    Assert.That(driver.FindElement(By.Id("lastName-error")).Text, Is.EqualTo("Last Name is required"));
  }
  [Test]
  public void carInsuranceRateOmitNumberOfAtfaultAccidentsVerifyValidationErrorOnNumberOfAtfaultAccidents() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(871, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("37");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("8");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector(".card-body")).Click();
    Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
  }
  [Test]
  public void carInsuranceRateOmitPostalCodeVerifyValidationErrorOnPostalCode() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(804, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code is required"));
  }
  [Test]
  public void carInsuranceRateOmitYearsOfDrivingExperienceVerifyValidationErrorOnYearsOfDrivingExperience() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(871, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("45");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector(".card-body")).Click();
    Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
  }
  [Test]
  public void carInsuranceRateYearsOfDrivingExperienceAs1VerifyYearsOfDrivingExperienceValidationError() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(804, 816);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Teena");
    driver.FindElement(By.Id("lastName")).SendKeys("Thomas");
    driver.FindElement(By.Id("address")).SendKeys("218 Weber");
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2H 1E8");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("tthomas5388@conestogac.on.ca");
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("25");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("-1");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    driver.FindElement(By.CssSelector(".card-body")).Click();
    Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 0."));
  }
}

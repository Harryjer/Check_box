using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
class Program
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/special-elements/check-button-test-3/";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement element = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(1)"));

        greenMessage(element.GetAttribute("value"));

        IWebElement element1 = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(3)"));

        redMessage(element1.GetAttribute("value"));

        Thread.Sleep(3000);
        driver.Quit();
    }
    private static void greenMessage(string message)
    {
        System.Console.ForegroundColor = System.ConsoleColor.Green;
        System.Console.WriteLine(message);
        System.Console.ForegroundColor = System.ConsoleColor.White;
    }

    private static void redMessage(string message)
    {
        System.Console.ForegroundColor = System.ConsoleColor.Red;
        System.Console.WriteLine(message);
        System.Console.ForegroundColor = System.ConsoleColor.White;
    }
}


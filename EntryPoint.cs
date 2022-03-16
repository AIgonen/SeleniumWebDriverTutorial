
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {

        string url = "https://testing.todorvachev.com/id/";
        string urlClass = "https://testing.todorvachev.com/class-name/";
        string urlCss = "https://testing.todorvachev.com/css-path/";

        string id = "testImage";
        string className = "testClass";
        string cssPath = "#post-108 > div > figure > img";
        string XPath = "//*[@id=\"post-108\"]/div/figure/img";


        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Id(id));

        if (element.Displayed)
        {
            GreenMessage("I can see an elementID");
        }
        else
        {
            RedMessage("I cant see an element");
        }

        driver.Navigate().GoToUrl(urlClass);
        IWebElement elementClass = driver.FindElement(By.ClassName(className));
        Console.WriteLine(elementClass.Text);

        driver.Navigate().GoToUrl(urlCss);

        IWebElement elementCssPath = driver.FindElement(By.CssSelector(cssPath));
        IWebElement elementXPath = driver.FindElement(By.XPath(XPath));
        if (elementCssPath.Displayed)
        {
            GreenMessage("I can see an element CSS");
        }
        else
        {
            RedMessage("I cant see an element");
        }

        if (elementXPath.Displayed)
        {
            GreenMessage("I can see an element XPath ");
        }
        else
        {
            RedMessage("I cant see an element");
        }
        //IWebDriver driver = new ChromeDriver();

        //driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");

        //IWebElement element = driver.FindElement(By.Name("myName"));

        //if (element.Displayed)
        //{
        //    GreenMessage("I can see an element");
        //}
        //else
        //{
        //    RedMessage("I cant see an element");
        //}

        driver.Quit();
        Console.ReadKey();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

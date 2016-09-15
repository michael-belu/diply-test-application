using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiplyTestApp
{

    class Program
    {
        public static Boolean StopIfAtomicTestFailed = false;
        public static int sleep_between_atomic_tests = 0;

        static int Main(string[] args)
        {
            int _global_returned_var = 0;
            String testparam_returned_var = _env.InitApp(args);
            //testparam_returned_var = "C609";
            _test_suite.runTest(testparam_returned_var);
            //_test_suite.runSuite(some_suite);
            return _global_returned_var;
        }

        /////////////////////////////////////=============== END MAIN ===============
    }
}















//        static WEBELEMENT webelement;
//String chromedrive_path = ;
//static int testvar = 10;

//////selenium vars




//public struct WEBELEMENT
//{
//public String _element_type;
//public String _element_finder;

//}

//////selenium vars

//static IWebElement iwebelement;


////////////////////////////delete this
//IWebElement WebElement = iwebdriver.FindElement(By.XPath("//div[@class='facetContainerDiv']/div"));
// Create an IList and intialize it with all the elements of div under div with **class as facetContainerDiv**
//IList<IWebElement> AllCheckBoxes = WebElement.FindElements(By.XPath("//label/input"));
//int RowCount = WebElement.FindElements(By.XPath("//label/input")).Count;
//for (int i = 0; i < RowCount; i++)
//{
// Check the check boxes based on index
//AllCheckBoxes[i].Click();

//}
//Console.WriteLine(RowCount);
//Console.ReadLine();

////////////////////////////delete this


///////////do test stuff
//runTest(testID);
//String varasset =_assets.retrieve_asset("Hamburger");
//            System.Console.WriteLine(varasset);

//runTest("C610");

//_test_suite.some_function();

//_action_methods.method_function();

//iwebdriver = null;



//Console.WriteLine(_test_suite.runTest("C610",iwebdriver));

//webelement = _assets.retrieve_asset("Hamburger.Closed");
//iwebelement = _action_methods.assign_element(webelement._element_type, webelement._element_finder, iwebdriver);//to iwebelement            
//iwebelement.Click();


//webelement = _assets.retrieve_asset("Hamburger.Open");
//iwebelement=_action_methods.assign_element(webelement._element_type, webelement._element_finder, iwebdriver);//to iwebelement            
//Console.WriteLine("check visible:" + _test_suite.atomicTest(iwebelement, "visible"));

//Console.WriteLine(_action_methods.element_contains_text(iwebelement, "Trending"));

//if (_action_methods.check_page("Trending", iwebelement, iwebdriver)==true)
//{
//  Console.WriteLine("I am on trending page");
//}

//if (_action_methods.check_visibility(_action_methods.assign_element(_assets.retrieve_asset("Navbar.Trending")._element_type, _assets.retrieve_asset("Navbar.Trending")._element_finder, iwebdriver)))
//{
//    Console.WriteLine("elem is visible!");
//}


//IWebElement iwebelement = iwebdriver.FindElement(By.ClassName("offcanvas-toggle js-toggle-menu"));// open closed");
//IWebElement iwebelement = iwebdriver.FindElement(By.CssSelector("#feature-hamburger"));// open closed");
//IWebElement element = iwebdriver.FindElement(By.CssSelector(".offcanvas-toggle.js-toggle-menu"));// open closed");


//element.Click();

//_assets.asset_value("PrivacyPolicyPageIdentifier");

//_assets.asset_type("Hamburger.Closed")

//assign_element(_assets.retrieve_asset("Hamburger.Closed")._element_type, _assets.retrieve_asset("Hamburger.Closed")._element_finder);//to iwebelement            
//iwebelement.Click();


//sleep


//            assign_element(_assets.retrieve_asset("Hamburger.Open")._element_type, _assets.retrieve_asset("Hamburger.Open")._element_finder);//to iwebelement

//          iwebelement.Click();


/////////////////////////////////////exception
//element = iwebdriver.FindElement(By.CssSelector("33.offcanvas-toggle.js-toggle-menu.open.closed"));// open closed");
//element.Click();
/////////////////////////////////////exception

//System.Threading.Thread.Sleep(1000);

//_action_methods.scroll_user_agent(iwebdriver, "TrendingPageScrollDownToElement");//"CSS", "#cards > div:nth-child(9)");

//System.Threading.Thread.Sleep(1000);

//_action_methods.close_user_agent(iwebdriver);





///////////do stuff

//////////////delete
/* public static IWebElement GetElement(this IWebDriver driver, By selector, int tries = 10)
{
 for (int i = 1; i <= tries; i++)
 {
     try
     {
         return driver.FindElement(selector);
     }
     catch (WebDriverException)
     {
         System.Threading.Thread.Sleep(200);
     }
 }
 return null;
}*/
//////////////delete


////////////////RETURN FROM MAIN/////////////


//////////////////////////////////LOCAL FUNCTIONS




/*
static void scroll_user_agent(String selector_type, String selector_element, IWebDriver webdr)//scrolls to the element on page
{
    IWebElement element_scroll;

    Actions actions = new Actions(iwebdriver);

    if (selector_type == "CSS") {element_scroll = webdr.FindElement(By.CssSelector(selector_element)); actions.MoveToElement(element_scroll); }
    if (selector_type == "ID") {element_scroll = webdr.FindElement(By.Id(selector_element)); actions.MoveToElement(element_scroll); }
    if (selector_type == "CLASS") {element_scroll = webdr.FindElement(By.ClassName(selector_element)); actions.MoveToElement(element_scroll); }
    if (selector_type == "NAME") {element_scroll = webdr.FindElement(By.Name(selector_element)); actions.MoveToElement(element_scroll); }
    if (selector_type == "XPATH") {element_scroll = webdr.FindElement(By.XPath(selector_element)); actions.MoveToElement(element_scroll); }

    actions.Perform();
}
*/

/*
public static IWebElement assign_element(String selector_type, String selector_element, IWebDriver idrive)
{
    IWebElement function_web_element=null;
    if (selector_type == "CSS") { function_web_element= idrive.FindElement(By.CssSelector(selector_element)); }
    if (selector_type == "ID") { function_web_element= idrive.FindElement(By.Id(selector_element)); }
    if (selector_type == "CLASS") { function_web_element= idrive.FindElement(By.ClassName(selector_element)); }
    if (selector_type == "NAME") { function_web_element= idrive.FindElement(By.Name(selector_element)); }
    if (selector_type == "XPATH") { function_web_element= idrive.FindElement(By.XPath(selector_element)); }
    return function_web_element;
}
*/

//public static void dummy_function()
//{
//  Console.WriteLine("Program function called from inside class");
//}

/*      
  public static Boolean check_page(String pagename, IWebElement ielemweb)
  {
      Boolean var_to_return = false;
      ielemweb=assign_element(_assets.retrieve_asset(pagename + "PageIdentifier")._element_type, _assets.retrieve_asset(pagename + "PageIdentifier")._element_finder, iwebdriver);
      //Console.WriteLine(_assets.asset_value(pagename + "PageIdentifier"));
      //Console.WriteLine("iwebelementtext:" + iwebelement.Text);
      if (_assets.asset_value(pagename + "PageIdentifier").ToUpper() == ielemweb.Text.ToUpper())
      {var_to_return = true;}
      else { var_to_return = false; }
      //iwebelement
      return var_to_return;
  }

  */




//////////////////////////////////END local functions



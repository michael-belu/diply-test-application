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
    class _action_methods
    {
        
        public static IWebDriver open_user_agent()
        {
            IWebDriver idr;
            idr = new ChromeDriver(@"E:\Dev Environment\Michael\diply\chromedriver");
            return idr;
        }

        public static void maximize_user_agent(IWebDriver idr)
        {
            idr.Manage().Window.Maximize();
        }

        public static void close_user_agent(IWebDriver idr)
        {
            idr.Close();
        }

        public static void navigate_user_agent(IWebDriver idr, String url_address)
        {
            //IWebDriver internal_driver;

            idr.Navigate().GoToUrl(url_address);

        }


        public static void scroll_user_agent(IWebDriver webdr, IWebElement iwel)//String asset)//scrolls to the element on page
        {
            //_assets.WEBELEMENT w_elem;
            //IWebElement iwelem;
            //String selector_type;
            //String selector_element;
            //w_elem._element_type = "NULL";
            //w_elem._element_finder = "NULL";

            //w_elem = _assets.retrieve_asset(asset);
            //selector_type = w_elem._element_type;
            //selector_element = w_elem._element_finder;

            //iwelem=assign_element();
            Actions actions = new Actions(webdr);

            /*
            if (selector_type == "CSS") { iwelem = webdr.FindElement(By.CssSelector(selector_element)); actions.MoveToElement(iwelem); }
            if (selector_type == "ID") { iwelem = webdr.FindElement(By.Id(selector_element)); actions.MoveToElement(iwelem); }
            if (selector_type == "CLASS") { iwelem = webdr.FindElement(By.ClassName(selector_element)); actions.MoveToElement(iwelem); }
            if (selector_type == "NAME") { iwelem = webdr.FindElement(By.Name(selector_element)); actions.MoveToElement(iwelem); }
            if (selector_type == "XPATH") { iwelem = webdr.FindElement(By.XPath(selector_element)); actions.MoveToElement(iwelem); }
            */

            actions.MoveToElement(iwel);

            actions.Perform();
        }

        public static void user_agent_go_back(IWebDriver webdr)
        {
            webdr.Navigate().Back();
        }

        public static IWebElement assign_element(String selector_type, String selector_element, IWebDriver idrive)
        {
            IWebElement function_web_element = null;
            if (selector_type == "CSS") { function_web_element = idrive.FindElement(By.CssSelector(selector_element)); }
            if (selector_type == "ID") { function_web_element = idrive.FindElement(By.Id(selector_element)); }
            if (selector_type == "CLASS") { function_web_element = idrive.FindElement(By.ClassName(selector_element)); }
            if (selector_type == "NAME") { function_web_element = idrive.FindElement(By.Name(selector_element)); }
            if (selector_type == "XPATH") { function_web_element = idrive.FindElement(By.XPath(selector_element)); }
            return function_web_element;
        }
        
        public static Boolean check_page(String pagename, IWebElement ielemweb, IWebDriver webdr)
        {
            Boolean var_to_return = false;
            ielemweb = assign_element(_assets.retrieve_asset(pagename + "PageIdentifier")._element_type, _assets.retrieve_asset(pagename + "PageIdentifier")._element_finder, webdr);
            //Console.WriteLine(_assets.asset_value(pagename + "PageIdentifier"));
            //Console.WriteLine("iwebelementtext:" + iwebelement.Text);
            if (_assets.asset_value(pagename + "PageIdentifier").ToUpper() == ielemweb.Text.ToUpper())
            { var_to_return = true; }
            else { var_to_return = false; }
            //iwebelement
            return var_to_return;
        }


        public static Boolean check_visibility(IWebElement ielemweb)
        {
            Boolean var_to_return = false;
            //int int_var = 0;
              if (ielemweb.Displayed) { var_to_return = true; }
              else { var_to_return = false; }
              return var_to_return;
        }

        public static Boolean check_hidden(IWebElement ielemweb)
        {
            Boolean var_to_return = false;
            //int int_var = 0;
            if (ielemweb.Displayed) { var_to_return = false; }
            else { var_to_return = true; }
            return var_to_return;
        }

        public static Boolean click_element(IWebElement ielemweb)
        {

            Boolean var_to_return = true;
            
            ielemweb.Click();//ADDRESS EXCEPTION
            //int int_var = 0;
            //if (ielemweb.Displayed) { var_to_return = true; }
            //else { var_to_return = false; }
            return var_to_return;
        }

        public static Boolean element_contains_text(IWebElement ielemweb, String text_contained)
        {
            Boolean var_to_return = false;
            //int int_var = 0;
            //        if (ielemweb.Displayed) { var_to_return = true; }
            //          else { var_to_return = false; }
            //Console.WriteLine(ielemweb.Text);
            if (ielemweb.Text.ToUpper().Contains(text_contained.ToUpper()))
            { var_to_return = true; }
            else { var_to_return = false; }
            return var_to_return;
        }


        public static void function_general(IWebDriver driver, IWebElement element, string value, string elementtype)
            {


    
            }

    }
}

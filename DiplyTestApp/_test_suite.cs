using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplyTestApp
{
    class _test_suite
    {

        static IWebDriver iwebdriver;

        public struct TESTELEMENT
        {}
        public static TESTELEMENT retrieve_test(String teststring)
        {
            TESTELEMENT testelement;

            return testelement;
        }

        public static String TestCase(String testID)
        {
            String str_to_ret = "NULL";

            if (testID == "C609")
            {
                str_to_ret = ":Open-browser;" +
                              ":Switch-desktop-mode;" +
                              ":http://diply-staging.azurewebsites.net/->Navigate;" +
                              "blabla_test;" +
                              "blabla_element->blahblah_action;" +
                              ":blabla_element->click;" +
                              ":Hamburger.Open->click;" +
                              ":Hamburger.Closed->bla_command;" +
                              ":blabla_element->blabla_command;" +
                              ":bla_command;" +
                              "Navbar-Left->bla_action;" +
                              "Navbar-Left->Visible;" +
                              "Navbar-Right->Visible;" +
                              "Navbar-Left->Contains(Trending);" +
                              "Navbar-Left->Contains(Life);" +
                              ":Hamburger.Closed->click;" + //remove and check only on hamburger.open
                              ":Hamburger.Open->click;" +
                              
                              "Hamburger_fake.Open->wrong_action;" +
                              ":Exit;";
            }

                               if (testID == "C610") { str_to_ret =   ":Open-browser;" +
                                                   ":Switch-desktop-mode;" +
                                                   ":http://diply-staging.azurewebsites.net/->Navigate;" +
                                                   "Navbar-Left->Visible;" +
                                                   "Navbar-Right->Visible;" +
                                                   "Navbar-Left->Contains(Trending);" +
                                                   "Navbar-Left->Contains(Life);" +
                                                   "Navbar-Left->Contains(Videos);" +
                                                   "Navbar-Left->Contains(Style);" +
                                                   "Navbar-Right->Contains(DIY);" +
                                                   "Navbar-Right->Contains(Funny);" +
                                                   "Navbar-Right->Contains(Parenting);" +
                                                   "Navbar-Right->Contains(Inspirational);" +
                                                   ":ScrollTo(TrendingPageScrollDownToElement);" +
                                                   "Navbar-Left->Hidden;" +
                                                   "Navbar-Right->Hidden;" +
                                                   ":ScrollTo(TrendingPageScrollUpToElement);" +
                                                   "Navbar-Left->Visible;" +
                                                   "Navbar-Right->Visible;" +
                                                   ":Switch-mobile-mode;" +
                                                   "Navbar-Left->Hidden;" +
                                                   "Navbar-Right->Hidden;" +
                                                   ":Switch-desktop-mode;" +
                                                   "Hamburger.Closed->Visible;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   "LeftSideMenuBar.Open->Visible;" +
                                                   "Hamburger.Open->Visible;" +
                                                   "LeftSideMenuBar.Open->Contains(Trending);" +
                                                   "LeftSideMenuBar.Open->Contains(Life);" +
                                                   "LeftSideMenuBar.Open->Contains(Videos);" +
                                                   "LeftSideMenuBar.Open->Contains(Style);" +
                                                   "LeftSideMenuBar.Open->Contains(DIY);" +
                                                   "LeftSideMenuBar.Open->Contains(Funny);" +
                                                   "LeftSideMenuBar.Open->Contains(Parenting);" +
                                                   "LeftSideMenuBar.Open->Contains(Inspirational);" +
                                                   "LeftSideMenuBar.Open->Contains(About Us);" +
                                                   "LeftSideMenuBar.Open->Contains(Advertise);" +
                                                   "LeftSideMenuBar.Open->Contains(Careers);" +
                                                   "LeftSideMenuBar.Open->Contains(Terms of Use);" +
                                                   "LeftSideMenuBar.Open->Contains(Privacy Policy);" +
                                                   ":Hamburger.Open.Trending->Click;" +
                                                   "TrendingPage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.Life->Click;" +
                                                   "LifePage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.Videos->Click;" +
                                                   "VideosPage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.Style->Click;" +
                                                   "StylePage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.DIY->Click;" +
                                                   "DIYPage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.Funny->Click;" +
                                                   "FunnyPage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.Parenting->Click;" +
                                                   "ParentingPage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.Inspirational->Click;" +
                                                   "InspirationalPage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.AboutUs->Click;" +
                                                   "AboutUsPage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.Advertise->Click;" +
                                                   "AdvertisePage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.Careers->Click;" +
                                                   "CareersPage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.TermsofUse->Click;" +
                                                   "TermsofusePage->CheckPage;" +
                                                   ":Back;" +
                                                   ":Hamburger.Closed->Click;" +
                                                   ":Hamburger.Open.PrivacyPolicy->Click;" +
                                                   "PrivacyPolicyPage->CheckPage;" +
                                                   ":Back;" +
                                                   "Hamburger.Open.Trending->Hover;" +
                                                   "Hamburger.Open.AboutUs->Hover;" +
                                                   ":MultilingualIcon.Closed->Click;" +
                                                   "MultilingualIcon.Open->Visible;" +
                                                   "MultilingualIcon.Open.English->Hover;" +
                                                   ":MultilingualIcon.Open->Click;" +
                                                   ":MultilingualIcon.Closed->Click;" +
                                                   ":MultilingualIcon.Open.Espanol->Click;" +
                                                   "MultilingualIcon.Open->Hidden;" +
                                                   "MustReadsTitle->Contains(Lo Que Debes Leer);" +
                                                   ":MultilingualIcon.Closed->Click;" +
                                                   ":MustReadsTitle->Click;" +
                                                   "MultilingualIcon.Open->Hidden;" +
                                                   ":Exit;";}
            return str_to_ret;
        }

        public static Boolean atomicAction(String element_string, String action_string, String data_string)
        {
            Boolean var_to_ret = true;
            IWebElement iwelem = null;
            //int at_test_number = 0;
            Boolean command_flag = false;
            Boolean action_string_flag = false;
            Boolean exception_flag = false;
            Boolean action_flag = false;
            Boolean null_element = false;
            Boolean null_action = false;
            Boolean null_data = false;
            Boolean element_not_found_flag = false;

            if (element_string.ToUpper() == "null".ToUpper())
            { null_element = true; }
            if (action_string.ToUpper() == "null".ToUpper())
            { null_action = true; }
            if (data_string.ToUpper() == "null".ToUpper())
            { null_data = true; }


            try
            {
                iwelem = _action_methods.assign_element(_assets.retrieve_asset(element_string)._element_type, _assets.retrieve_asset(element_string)._element_finder, iwebdriver);
                //if (iwelem == null) { exception_flag = true; }
            }
            catch (WebDriverException)
            {
                exception_flag = true;
            }

            if ((iwelem == null) && (!null_element)){ element_not_found_flag = true; }


            if (action_string.Substring(0, 1) == ":")//command
            { //browser command
                command_flag = true;
            }
            else //atomic test
            { }//else

            if (command_flag == false) //test action
            {
                //at_test_number++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Atomic test>");
                Console.ForegroundColor = ConsoleColor.White;
                if (!null_element) { Console.Write(" Element:" + element_string); }
                if (!null_action) { Console.Write(" Test:" + action_string); }
                if (!null_data) { Console.Write(" Data:" + data_string); }



                if (iwelem == null)
                {
                    //exception_flag_command = true;
                }

                else
                {

                    var_to_ret = false;
                    action_flag = false;

                    if (action_string.ToUpper() == "VisIble".ToUpper())
                    {
                        action_flag = true;
                        if ((_action_methods.check_visibility(iwelem)) == true)
                        { var_to_ret = true; }
                        else { var_to_ret = false; }
                    }

                    if (action_string.ToUpper() == "HiDDeN".ToUpper())
                    {
                        action_flag = true;
                        if ((_action_methods.check_hidden(iwelem)) == true)
                        { var_to_ret = true; }
                        else { var_to_ret = false; }
                    }
                    

                    if (action_string.ToUpper() == "CoNtAiNs".ToUpper())
                    {
                        action_flag = true;
                        if ((_action_methods.element_contains_text(iwelem, data_string)) == true)
                        { var_to_ret = true; }
                        else { var_to_ret = false; }
                    }


                    Console.Write(" Passed:");
                    if (var_to_ret == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(var_to_ret);
                    //Console.WriteLine();


                }//else iwelem==null

                Console.WriteLine("");




                /*
                if (iwelem == null)
                {
                    //exception_flag_command = true;
                }

                else
                {*/
                    if (action_flag == false)
                    {
                        var_to_ret = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--Error: Test \"" + action_string + "\" not defined.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                //}


                if (((exception_flag == true) && (null_element == false))|| (element_not_found_flag))
                {
                    var_to_ret = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--Error: Element \"" + element_string + "\" not found.");// + " Action:" + action_string + " Data:" + data_string);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            else
            { //command action
                //Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("Command:>");
                Console.ForegroundColor = ConsoleColor.White;
                //action_string = action_string.Substring(1);
                if (!null_element) { Console.Write(" Element:" + element_string); }
                if (!null_action) { Console.Write(" Action:" + action_string.Substring(1)); }
                if (!null_data) { Console.Write(" Data:" + data_string); }
                //Console.WriteLine("");

                action_string_flag = false;
                if (action_string.ToUpper() == ":Open-browser".ToUpper())
                {
                    action_string_flag = true;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    iwebdriver = _action_methods.open_user_agent();

                }

                if (action_string.ToUpper() == ":Switch-desktop-mode".ToUpper())
                {
                    action_string_flag = true;
                    _action_methods.maximize_user_agent(iwebdriver);
                    ///Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("debug----- " + action_string + " is not implemented");
                    //Console.ForegroundColor = ConsoleColor.White;
                }

                if (action_string.ToUpper() == ":Navigate".ToUpper())
                {
                    action_string_flag = true;
                    _action_methods.navigate_user_agent(iwebdriver, element_string);
                }

                if (action_string.ToUpper() == ":Click".ToUpper())
                {
                    action_string_flag = true;
                    if (!element_not_found_flag)
                    {
                        _action_methods.click_element(iwelem);
                    }
                }

                if (action_string.ToUpper() == ":scRoLLTO".ToUpper())
                {
                    action_string_flag = true;
                    if (!element_not_found_flag)
                    {
                        _action_methods.scroll_user_agent(iwebdriver, iwelem);
                    }
                }

                /*
                if (action_string.ToUpper() == ":bAcK".ToUpper())
                {
                    action_string_flag = true;
                    _action_methods.user_agent_go_back(iwebdriver);
                }*/
                

                if (action_string.ToUpper() == ":Exit".ToUpper())
                {
                    action_string_flag = true;
                    _action_methods.close_user_agent(iwebdriver);
                }

                
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Exec:");
                if ((action_string_flag == false) || ((exception_flag == true) && (null_element == false)) || ((element_not_found_flag) && (action_string.ToUpper() != ":navigate".ToUpper())))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Failed");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Success");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("");

                if (action_string_flag == false)
                {
                    var_to_ret = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--Error: Command \"" + action_string + "\" not understood.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (((exception_flag == true) && (null_element == false)) || (element_not_found_flag))
                {
                    var_to_ret = false;

                    if (action_string.ToUpper() != ":navigate".ToUpper())
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("--Error: Element \"" + element_string);

                        
                        /*if (element_not_found_flag)
                        {
                            Console.WriteLine("\" not available.");
                        }
                        else
                        {*/
                            Console.WriteLine("\" not found.");// + " Action:" + action_string + " Data:" + data_string);
                        //}
                        
                    }

                    
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.ForegroundColor = ConsoleColor.White;
            }


            return var_to_ret;
        }




        public static Boolean atomicAction_deprecated1(String element_string, String action_string, String data_string)
        {
            Boolean var_to_ret = true;
            IWebElement iwelem = null;
            //int at_test_number = 0;
            Boolean command_flag = false;
            Boolean action_string_flag = false;
            Boolean exception_flag = false;
            Boolean action_flag = false;
            Boolean null_element = false;
            Boolean null_action = false;
            Boolean null_data = false;
            String elemtyp = "";
            String elemfinder = "";


            if (element_string.ToUpper() == "null".ToUpper())
            { null_element = true; }
            if (action_string.ToUpper() == "null".ToUpper())
            { null_action = true; }
            if (data_string.ToUpper() == "null".ToUpper())
            { null_data = true; }

            try
            {
                elemtyp = _assets.retrieve_asset(element_string)._element_type;
                elemfinder = _assets.retrieve_asset(element_string)._element_finder;
                iwelem = _action_methods.assign_element(elemtyp, elemfinder, iwebdriver);
                null_element = false;
                if (elemfinder == "NULL") { null_element = true; }
            }
            catch (WebDriverException) {exception_flag = true;}

            
            if (action_string.Substring(0, 1) == ":") // if browser command :
            { command_flag = true;}
            

            if (command_flag == false) //test action
            {
                //at_test_number++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Atomic test>");
                Console.ForegroundColor = ConsoleColor.White;
                if (!null_element) { Console.Write(" Element:" + element_string); }
                if (!null_action) { Console.Write(" Action:" + action_string); }
                if (!null_data) { Console.Write(" Data:" + data_string); }
                
                if (exception_flag == true)
                {
                    
                }

                else
                {
                    var_to_ret = false;
                    action_flag = false;

                    if (action_string.ToUpper() == "Visible".ToUpper())
                    {
                        action_flag = true;
                        if ((_action_methods.check_visibility(iwelem)) == true)
                        { var_to_ret = true; }
                        else { var_to_ret = false; }
                    }

                    if (action_string.ToUpper() == "CoNtAiNs".ToUpper())
                    {
                        action_flag = true;
                        if ((_action_methods.element_contains_text(iwelem, data_string)) == true)
                        { var_to_ret = true; }
                        else { var_to_ret = false; }
                    }


                    Console.Write(" Passed:");
                    if (var_to_ret == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.Write(var_to_ret);
                    Console.WriteLine();

                    if (action_flag == false)
                    {
                        var_to_ret = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--Error: Action \"" + action_string + "\" not recognized.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                }//else from if (exception_flag == true)

                //Console.WriteLine("");

                /*
                if (exception_flag == true)
                {
                    
                }

                else
                {
                    if (action_flag == false)
                    {
                        var_to_ret = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--Error: Action \"" + action_string + "\" not defined.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                */
                Console.WriteLine("Flag me1!");
                Console.WriteLine(exception_flag);
                if (null_element == false)//((exception_flag == true) && 
                {
                    Console.WriteLine("Flag me2!");
                    var_to_ret = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--Error: Element \"" + element_string + "\" not found.");// + " Action:" + action_string + " Data:" + data_string);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            else
            { //command action
                //Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("Command:>");
                Console.ForegroundColor = ConsoleColor.White;
                //action_string = action_string.Substring(1);

                if (!null_element) { Console.Write(" Element:" + element_string); }
                if (!null_action) { Console.Write(" Action:" + action_string); }
                if (!null_data) { Console.Write(" Data:" + data_string); }

                //if (element_string != "null") { Console.Write(" Element:" + element_string); }
                //if (action_string != "null") { Console.Write(" Action:" + action_string.Substring(1)); }
                //if (data_string != "null") { Console.Write(" Data:" + data_string); }
                //Console.WriteLine("");

                action_string_flag = false;
                if (action_string.ToUpper() == ":Open-browser".ToUpper())
                {
                    action_string_flag = true;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    iwebdriver = _action_methods.open_user_agent();

                }

                if (action_string.ToUpper() == ":Switch-desktop-mode".ToUpper())
                {
                    action_string_flag = true;
                    _action_methods.maximize_user_agent(iwebdriver);
                    ///Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("debug----- " + action_string + " is not implemented");
                    //Console.ForegroundColor = ConsoleColor.White;
                }

                if (action_string.ToUpper() == ":Navigate".ToUpper())
                {
                    action_string_flag = true;
                    _action_methods.navigate_user_agent(iwebdriver, element_string);
                }

                if (action_string.ToUpper() == ":Click".ToUpper())
                {
                    action_string_flag = true;
                    _action_methods.click_element(iwelem);
                }

                if (action_string.ToUpper() == ":Exit".ToUpper())
                {
                    action_string_flag = true;
                    _action_methods.close_user_agent(iwebdriver);
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Exec:");
                if ((action_string_flag == false) || ((exception_flag == true) && (null_element == false)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Failed");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Success");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("");

                if (action_string_flag == false)
                {
                    var_to_ret = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--Error: Command \"" + action_string + "\" not understood.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if ((exception_flag == true)&& (null_element == false))
                {
                    var_to_ret = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--Error: Element \"" + element_string + "\" not found.");// + " Action:" + action_string + " Data:" + data_string);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.ForegroundColor = ConsoleColor.White;
            }


            return var_to_ret;


        }

        public static Boolean atomicAction_deprecated(String element_string, String action_string, String data_string)
        {
            Boolean var_to_ret = true;
            IWebElement iwelem=null;
            //int at_test_number = 0;
            Boolean command_flag = false;
            Boolean action_string_flag = false;
            Boolean exception_flag = false;
            Boolean action_flag = false;
            Boolean null_element = false;

            if (element_string.ToUpper() == "null".ToUpper())
            {
                null_element = true;
            }

            try
            {
                iwelem = _action_methods.assign_element(_assets.retrieve_asset(element_string)._element_type, _assets.retrieve_asset(element_string)._element_finder, iwebdriver);
            }
            catch (WebDriverException)
            {
                exception_flag = true;             
            }


            if (action_string.Substring(0, 1) == ":")//command
            { //browser command
                command_flag = true;
                
                //Console.WriteLine("debug-----Command - following");
            }
            else
            { //test action

                
            }//else
            if (command_flag == false) //test action
            {
                //at_test_number++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Atomic test:>");
                Console.ForegroundColor = ConsoleColor.White;
                if (element_string != "null") { Console.Write(" Element:" + element_string); }
                if (action_string != "null") { Console.Write(" Action:" + action_string); }
                if (data_string != "null") { Console.Write(" Data:" + data_string); }
                

                
                if (iwelem == null)
                {
                    //exception_flag_command = true;
                }

                else
                {

                    var_to_ret = false;
                    action_flag = false;

                    if (action_string.ToUpper() == "Visible".ToUpper())
                    {
                        action_flag = true;
                        if ((_action_methods.check_visibility(iwelem)) == true)
                        { var_to_ret = true; }
                        else { var_to_ret = false; }
                    }

                    if (action_string.ToUpper() == "Contains".ToUpper())
                    {
                        action_flag = true;
                        if ((_action_methods.element_contains_text(iwelem,data_string)) == true)
                        { var_to_ret = true; }
                        else { var_to_ret = false; }
                    }
                    

                    Console.Write(" Passed:");
                    if (var_to_ret == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(var_to_ret);
                    //Console.WriteLine();
                    

                }//else iwelem==null

                Console.WriteLine("");





                if (iwelem == null)
                {
                    //exception_flag_command = true;
                }

                else
                {
                    if (action_flag == false)
                    {
                        var_to_ret = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--Error: Action \"" + action_string + "\" not defined.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }


                if ((exception_flag == true)&&(null_element == false))
                {
                    var_to_ret = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--Error: element \"" + element_string + "\" not found.");// + " Action:" + action_string + " Data:" + data_string);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }
            else
            { //command action
                //Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("Command:>");
                Console.ForegroundColor = ConsoleColor.White;
                //action_string = action_string.Substring(1);
                if (element_string != "null") { Console.Write(" Element:" + element_string); }
                if (action_string != "null") { Console.Write(" Action:" + action_string.Substring(1)); }
                if (data_string != "null") { Console.Write(" Data:" + data_string); }
                //Console.WriteLine("");

                action_string_flag = false;
                if (action_string == ":Open-browser")
                {
                    action_string_flag = true;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    iwebdriver = _action_methods.open_user_agent();

                }

                if (action_string == ":Switch-desktop-mode")
                {
                    action_string_flag = true;
                    _action_methods.maximize_user_agent(iwebdriver);
                    ///Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("debug----- " + action_string + " is not implemented");
                    //Console.ForegroundColor = ConsoleColor.White;
                }

                if (action_string == ":Navigate")
                {
                    action_string_flag = true;
                    _action_methods.navigate_user_agent(iwebdriver, element_string);
                }

                if (action_string == ":Click")
                {
                    action_string_flag = true;
                    _action_methods.click_element(iwelem);
                }

                if (action_string == ":Exit")
                {
                    action_string_flag = true;
                    _action_methods.close_user_agent(iwebdriver);
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Exec:");
                if ((action_string_flag == false)|| ((exception_flag == true) && (null_element == false)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Failed");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Success");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                    Console.WriteLine("");

                if (action_string_flag==false)
                {
                    var_to_ret = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--Error: Command \"" + action_string + "\" not understood.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if ((exception_flag == true) && (null_element == false))
                {
                    var_to_ret = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--Error: element \"" + element_string + "\" not found.");// + " Action:" + action_string + " Data:" + data_string);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
            
            
            return var_to_ret;
        }

        public static Boolean runTest(String testID)//, IWebDriver iwebd)
        {
            Boolean var_to_ret = true;
            String ParseTestString;
            String CurrentLine="";
            String CurrentElement="";
            String CurrentAction="";
            String CurrentData="";


            Boolean flag_command = false;
            //IWebElement iwe;
            int indexstr;
            int lenstr;

            ParseTestString = TestCase(testID);
            
            if (ParseTestString != "NULL") //test exists
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("....................");
                Console.WriteLine("Running testID: " + testID);
                Console.WriteLine("....................");
                Console.WriteLine("");


                while (ParseTestString.Length > 0)
                {
                    indexstr = ParseTestString.IndexOf(";");
                    CurrentLine = ParseTestString.Substring(0, indexstr);
                    ParseTestString = ParseTestString.Substring(indexstr + 1);

                    indexstr = CurrentLine.IndexOf(":");
                    if (indexstr >= 0)
                    {//action
                        flag_command = true;
                        CurrentLine = CurrentLine.Substring(1);
                    }


                    CurrentData = "";
                    CurrentElement = "";
                    CurrentAction = "";

                    //CurrentAction = CurrentLine.Substring(1);

                    indexstr = CurrentLine.IndexOf("->");
                    if (indexstr < 0)
                    {
                        CurrentAction = CurrentLine;
                    }
                    else
                    {
                        CurrentElement = CurrentLine.Substring(0, indexstr);
                        CurrentAction = CurrentLine.Substring(indexstr + 2);
                    }

                    indexstr = CurrentAction.IndexOf("(");
                    if (indexstr >= 0)
                    {
                        lenstr = CurrentAction.Length;
                        CurrentData = CurrentAction.Substring(indexstr + 1);
                        CurrentData = CurrentData.Substring(0, CurrentData.Length - 1);
                        CurrentAction = CurrentAction.Substring(0, indexstr);
                    }

                    if (CurrentElement == "")
                    {
                        CurrentElement = CurrentData;
                        CurrentData = "";
                    }

                    if (flag_command == true)
                    {
                        CurrentAction = ":" + CurrentAction;
                        flag_command = false;
                    }

                    if (CurrentAction == "") { CurrentAction = "null"; }
                    if (CurrentData == "") { CurrentData = "null"; }
                    if (CurrentElement == "") { CurrentElement = "null"; }

                    //Console.WriteLine("CE:" + CurrentElement + " CA:" + CurrentAction + " CD:" + CurrentData);
                    System.Threading.Thread.Sleep(Program.sleep_between_atomic_tests);
                    if (atomicAction(CurrentElement, CurrentAction, CurrentData))
                    {
                        //  Console.WriteLine("Atomic test passed");
                        //var_to_ret = true;
                    }
                    else
                    {
                        var_to_ret = false;
                        //return false;    //Console.WriteLine("Atomic test failed");
                    }


                    //CurrentElement = ParseTestString.Substring(0, indexstr);
                    //ParseTestString = ParseTestString.Substring(indexstr+2);
                    //Console.WriteLine("Current elem:" + CurrentElement);

                    //indexstr = ParseTestString.IndexOf(";");
                    //CurrentAction = ParseTestString.Substring(0, indexstr);

                    //Console.WriteLine("Current action:" + CurrentAction);

                    ///parse test string
                    //iwe=_action_methods.assign_element("","",iwebd)
                    //atomicTest(iwe,CurrentAction);
                }
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("...................");
                Console.WriteLine("");

                Console.Write("Test ID: " + testID + " execution finished");

                if (var_to_ret == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" (FAILED)");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" (PASSED)");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }// if (ParseTestString != "")
            else
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: TestID " + testID + " does not exist!");
                Console.ForegroundColor = ConsoleColor.White;
            } 



            return var_to_ret;
        }


        //public static void some_function()
        //{
        //  Program.dummy_function();

        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplyTestApp
{
    class _assets ////////////define test assets/elements here
    {


        public struct WEBELEMENT
        {
            public String _element_type;
            public String _element_finder;
        }

        public static WEBELEMENT retrieve_asset(String assetstring)
        {
            
            //String var_to_return = "Not found";
            WEBELEMENT w_elem;
            w_elem._element_type = "NULL";
            w_elem._element_finder = "NULL";
            


            //Element: Navbar-Left
            if (assetstring.ToUpper() == "Navbar-Left".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(1)"; }
            //Element: Navbar-Right
            if (assetstring.ToUpper() == "Navbar-Right".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(2)"; }

            
            //Element: Navbar -> Trending
            if (assetstring.ToUpper() == "Navbar.Trending".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(1) > li:nth-child(1) > a > span"; }
            //Element: Navbar -> Life
            if (assetstring.ToUpper() == "Navbar.Life".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(1) > li:nth-child(2) > a > span"; }
            //Element: Navbar -> Videos
            if (assetstring.ToUpper() == "Navbar.Videos".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(1) > li:nth-child(3) > a > span"; }
            //Element: Navbar -> Style
            if (assetstring.ToUpper() == "Navbar.Style".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(1) > li:nth-child(4) > a > span"; }
            //Element: Navbar -> DIY
            if (assetstring.ToUpper() == "Navbar.DIY".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(2) > li:nth-child(1) > a > span"; }
            //Element: Navbar -> Funny
            if (assetstring.ToUpper() == "Navbar.Funny".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(2) > li:nth-child(2) > a > span"; }
            //Element: Navbar -> Parenting
            if (assetstring.ToUpper() == "Navbar.Parenting".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(2) > li:nth-child(3) > a > span"; }
            //Element: Navbar -> Inspirational
            if (assetstring.ToUpper() == "Navbar.Inspirational".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-block.show-for-large.menu-group.head-wrap-category > div > ul:nth-child(2) > li:nth-child(4) > a > span"; }
            
            //Element: Hamburger Icon Closed
            if (assetstring.ToUpper() == "Hamburger.Closed".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = ".offcanvas-toggle.js-toggle-menu"; }
            //Element: Hamburger Icon Open
            if (assetstring.ToUpper() == "Hamburger.Open".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = ".offcanvas-toggle.js-toggle-menu.open.closed"; }

            //Element: Left Side Menu Bar Closed
            if (assetstring.ToUpper() == "LeftSideMenuBar.Closed".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = ".mobile-nav-panel.panel.panel-left"; }
            //Element: Left Side Menu Bar Open
            if (assetstring.ToUpper() == "LeftSideMenuBar.Open".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = ".mobile-nav-panel.panel.panel-left.is-active"; }

            //Element: Hamburger Menu -> Trending
            if (assetstring.ToUpper() == "Hamburger.Open.Trending".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(1) > a > span"; }
            //Element: Hamburger Menu -> Life
            if (assetstring.ToUpper() == "Hamburger.Open.Life".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(2) > a > span"; }
            //Element: Hamburger Menu -> Videos
            if (assetstring.ToUpper() == "Hamburger.Open.Videos".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(3) > a > span"; }
            //Element: Hamburger Menu -> Style
            if (assetstring.ToUpper() == "Hamburger.Open.Style".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(4) > a > span"; }
            //Element: Hamburger Menu -> DIY
            if (assetstring.ToUpper() == "Hamburger.Open.DIY".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(5) > a > span"; }
            //Element: Hamburger Menu -> Funny
            if (assetstring.ToUpper() == "Hamburger.Open.Funny".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(6) > a > span"; }
            //Element: Hamburger Menu -> Parenting
            if (assetstring.ToUpper() == "Hamburger.Open.Parenting".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(7) > a > span"; }
            //Element: Hamburger Menu -> Inspirational
            if (assetstring.ToUpper() == "Hamburger.Open.Inspirational".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(8) > a > span"; }
            //Element: Hamburger Menu -> About Us
            if (assetstring.ToUpper() == "Hamburger.Open.AboutUs".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(9) > a > span"; }
            //Element: Hamburger Menu -> Advertise
            if (assetstring.ToUpper() == "Hamburger.Open.Advertise".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(10) > a > span"; }
            //Element: Hamburger Menu -> Careers
            if (assetstring.ToUpper() == "Hamburger.Open.Careers".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(11) > a > span"; }
            //Element: Hamburger Menu -> Terms of Use
            if (assetstring.ToUpper() == "Hamburger.Open.TermsofUse".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(12) > a > span"; }
            //Element: Hamburger Menu -> Privacy Policy
            if (assetstring.ToUpper() == "Hamburger.Open.PrivacyPolicy".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.mobile-nav-panel.panel.panel-left.is-active > section > nav > span:nth-child(13) > a > span"; }

            //Element: Multilingual Icon Closed
            if (assetstring == "MultilingualIcon.Closed".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = ".language-toggle"; }
            //Element: Multilingual Icon Open
            if (assetstring == "MultilingualIcon.Open".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = ".language-toggle.open"; }
            //Element: Multilingual Icon Open -> English
            if (assetstring == "MultilingualIcon.Open.English".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#feature-language > ul > li:nth-child(1) > a"; }
            //Element: Multilingual Icon Open -> Espanol
            if (assetstring == "MultilingualIcon.Open.Espanol".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#feature-language > ul > li:nth-child(2) > a"; }
            //Element: Multilingual Icon Open -> Francais
            if (assetstring == "MultilingualIcon.Open.Francais".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#feature-language > ul > li:nth-child(3) > a"; }

            //Element: Must Reads Title
            if (assetstring.ToUpper() == "MustReadsTitle".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = ".must-read-title"; }

            
            //Element: Trending Page Identifier ----- the Trending Page will be refered as TrendingPage
            if (assetstring.ToUpper() == "TrendingPageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#mustread > h1"; }
            //Element: Life Page Identifier
            if (assetstring.ToUpper() == "LifePageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > section.cat-info > div.cat-auth > h2"; }
            //Element: Videos Page Identifier
            if (assetstring.ToUpper() == "VideosPageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > section.cat-info > div.cat-auth > h2"; }
            //Element: Style Page Identifier
            if (assetstring.ToUpper() == "StylePageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > section.cat-info > div.cat-auth > h2"; }
            //Element: DIY Page Identifier
            if (assetstring.ToUpper() == "DIYPageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > section.cat-info > div.cat-auth > h2"; }
            //Element: Funny Page Identifier
            if (assetstring.ToUpper() == "FunnyPageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > section.cat-info > div.cat-auth > h2"; }
            //Element: Parenting Page Identifier
            if (assetstring.ToUpper() == "ParentingPageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > section.cat-info > div.cat-auth > h2"; }
            //Element: Inspirational Page Identifier
            if (assetstring.ToUpper() == "InspirationalPageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > section.cat-info > div.cat-auth > h2"; }
            //Element: About Us Page Identifier
            if (assetstring.ToUpper() == "AboutUsPageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > div.about-diply.grid-container > div.vertical.title > h1"; }
            //Element: Advertise Page Identifier
            if (assetstring.ToUpper() == "AdvertisePageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > section.hero-header > div.header > div > h1 > span:nth-child(1)"; }
            //Element: Careers Page Identifier
            if (assetstring.ToUpper() == "CareersPageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > header > div.careers-header > div > h1"; }
            //Element: Terms of Use Page Identifier
            if (assetstring.ToUpper() == "TermsofUsePageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > div > div > h1"; }
            //Element: Privacy Policy Page Identifier
            if (assetstring.ToUpper() == "PrivacyPolicyPageIdentifier".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#main-window > div.grid-frame.vertical.main-view > div > div > div > h1"; }
            
            //Element: Trending Page ScrollDownTo Element
            if (assetstring.ToUpper() == "TrendingPageScrollDownToElement".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#cards > div:nth-child(13)"; }
            //Element: Trending Page ScrollUpTo Element
            if (assetstring.ToUpper() == "TrendingPageScrollUpToElement".ToUpper()) { w_elem._element_type = "CSS"; w_elem._element_finder = "#cards > div.feed-item.article.featured"; }

            




            return w_elem;
        }

        public static String asset_value(String assetstring)
        {

            String ret_string = "NULL";

            //Element: Trending Page Identifier
            if (assetstring == "TrendingPageIdentifier") { ret_string = "Must Reads"; }
            //Element Value: Life Page Identifier Value
            if (assetstring == "LifePageIdentifier") { ret_string = "Life"; }
            //Element Value: Videos Page Identifier Value
            if (assetstring == "VideosPageIdentifier") { ret_string = "Videos"; }
            //Element Value: Style Page Identifier Value
            if (assetstring == "StylePageIdentifier") { ret_string = "Style"; }
            //Element Value: DIY Page Identifier Value
            if (assetstring == "DIYPageIdentifier") { ret_string = "DIY"; }
            //Element Value: Funny Page Identifier Value
            if (assetstring == "FunnyPageIdentifier") { ret_string = "Funny"; }
            //Element Value: Parenting Page Identifier Value
            if (assetstring == "ParentingPageIdentifier") { ret_string = "Parenting"; }
            //Element Value: Inspirational Page Identifier Value
            if (assetstring == "InspirationalPageIdentifier") { ret_string = "Inspirational"; }
            //Element Value: About Us Page Identifier Value
            if (assetstring == "AboutUsPageIdentifier") { ret_string = "About Us"; }
            //Element Value: Advertise Page Identifier Value
            if (assetstring == "AdvertisePageIdentifier") { ret_string = "Align your brand with"; }
            //Element Value: Careers Page Identifier Value
            if (assetstring == "CareersPageIdentifier") { ret_string = "Careers at Diply"; }
            //Element Value: Terms of Use Page Identifier Value
            if (assetstring == "TermsofUsePageIdentifier") { ret_string = "Terms of Use"; }
            //Element Value: Privacy Policy Page Identifier Value
            if (assetstring == "PrivacyPolicyPageIdentifier") { ret_string="Privacy Policy"; }

            return ret_string;
        }
            ////Element Value: Privacy Policy Page Identifier Value


            //public static String asset_type(String assetstring)
            //{
            //  String var_to_return = "Not found";


            //return var_to_return;
            //}
        }//Class
}
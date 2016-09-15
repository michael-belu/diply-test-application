using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplyTestApp
{
    class _env
    {
        public static String InitApp(string[] arguments)
        {
            String retval="";
            int i_runner;
            String param_string = "";
            String param_type = "";
            String param_value = "";
            int indexstr;

            string _app_version = "0.1.2";
            Console.Clear();
            System.Console.WriteLine("");
            System.Console.WriteLine("RoundAssist Automated Testing Framework Application v " + _app_version);
            System.Console.WriteLine("[http://www.roundassist.com] (C) RoundAssist Inc. <contact@roundassist.com>");

            if (arguments.Length == 0)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("DiplyTestApp [-runtest:][testID] [-runsuite]");
                System.Console.WriteLine("");
                retval="";
                
            }

            else
            {   
                for (i_runner = 0; i_runner < arguments.Length; i_runner++)
                {
                    //System.Console.WriteLine(_arguments[i_runner]);
                    param_string = arguments[i_runner];
                    
                    indexstr = param_string.IndexOf("-runtest:");
                    //runtest
                    if (indexstr >= 0)
                    {
                        //runtestflag = true;
                        
                        indexstr = param_string.IndexOf(":");
                        param_type = param_string.Substring(0, indexstr);
                        param_value = param_string.Substring(indexstr + 1);
                        retval = param_value;
                        //Console.WriteLine(param_value);
                        //System.Console.WriteLine(param_type);
                        //System.Console.WriteLine(param_value);

                    }
                }
            }

            //retval = "C610";
            return retval;

            //arguments

        }
        
    }
}

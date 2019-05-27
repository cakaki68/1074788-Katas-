using System;

namespace kata1._2
{
    class Program
    {
   
            public static void main(String[] args)
            {
                try
                {

                    Args arg = new arg("l,p#,d*");
                    boolean logging = arg.Getboolean("d*");
                    int port = arg.Getint("p#");
                    String Directory = arg.Getstring("d*");
                    ExecuteApplication(logging, port, directory);

                }
    }
}

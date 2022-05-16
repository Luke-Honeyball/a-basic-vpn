using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "VPN";
            Console.Write("Enable vpn or not? (Yes/No):");
            
            string op = Console.ReadLine();
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            if (op.ToLower() == "yes")
            {
                string ip = "217.195.153.126";
                string port = "3128";
                
                key.SetValue("ProxyEnable", 1);
                key.SetValue("ProxyServer", ip + ":" + port);
                Console.WriteLine("connecting.. Press enter to continue");
                Console.ReadLine();
            }
            else {
                key.SetValue("ProxyEnable", 0);
                Console.WriteLine("disabled the vpn");
                Console.ReadLine();
            }

            
            
        }
    }
}

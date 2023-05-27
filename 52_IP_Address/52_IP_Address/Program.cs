using System;
using System.Net;

class Program
{
    static void Main()
    {
        string hostName = Dns.GetHostName(); // Get the host name of the machine
        IPHostEntry hostEntry = Dns.GetHostEntry(hostName); // Get the IP addresses associated with the host name

        foreach (IPAddress ipAddress in hostEntry.AddressList)
        {
            if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                Console.WriteLine("IP Address: " + ipAddress.ToString());
            }
        }

        Console.ReadLine();
    }
}

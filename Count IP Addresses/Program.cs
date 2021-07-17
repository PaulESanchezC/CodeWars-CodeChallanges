using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace Count_IP_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountIPAddresses.IpsBetween("0.0.0.1", "0.0.0.2"));
        }
    }
    public class CountIPAddresses
    {
        public static long IpsBetween(string start, string end)
        {
            IPAddress startIP = IPAddress.Parse(start);
            IPAddress endIP = IPAddress.Parse(end);

            byte[] startBytes = startIP.GetAddressBytes();
            byte[] endBytes = endIP.GetAddressBytes();

            Array.Reverse(startBytes);
            Array.Reverse(endBytes);


            return BitConverter.ToUInt32(endBytes) - BitConverter.ToUInt32(startBytes);
        }
    }

}

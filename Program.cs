//Design and implement a simple UDP-based client-server program in C# to demonstrate that UDP does not guarantee reliable data delivery
//1. The client rapidly sends a sequence of numbered messages(e.g "Packet1"."Packet 2",...."Packet 100") to the server using UDP datagrams.
//2. The server receives these packets and displays each message as it arrives.
//3. After transmission, the number of received packets is compared to the number of sent packets to observe any out-of-order arrival.
using System;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading;
class UDPClientLossDemo
{
    static void Main()
    {
        UdpClient client = new UdpClient();
        client.Connect("192.168.18.39",9000);
        for(int i = 1; i <= 50; i++)
        {
            string msg = $"Packet{i}";
            byte[] data = Encoding.ASCII.GetBytes(msg);
            client.Send(data, data.Length);
        }
        Console.WriteLine("All packets sent!");
        client.Close();
    }
}




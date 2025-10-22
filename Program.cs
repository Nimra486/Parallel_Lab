//Design and implement a UDP-based client server application in C# where the client and server communicate using datagrams
//1. The client sends an integer value to the server.
//2.The server recieves this integer, then prompts the user(on the server) to enter another integer value.
//3. The server adds both integer values and sends the sum back to the client.
//4. The client then displays the received sum o its console.
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
class UDPClient
{
    static void Main()
    {
        UdpClient client = new UdpClient();
        client.Connect("192.168.18.39", 9000);
        Console.Write("Enter Your Integer value(client side):");
        int ClientValue = int.Parse(Console.ReadLine());
        byte[] data = Encoding.ASCII.GetBytes(ClientValue.ToString());
        IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, 0);
        byte[] receivedData = client.Receive(ref serverEP);
        string result = Encoding.ASCII.GetString(receivedData);
        Console.WriteLine($"Sum received from server:{result}");
        client.Close();
    }
}
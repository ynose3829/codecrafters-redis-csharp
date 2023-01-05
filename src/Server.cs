using System.Net;
using System.Net.Sockets;

// You can use print statements as follows for debugging, they'll be visible when running tests.
Console.WriteLine("Logs from your program will appear here!");

// Uncomment this block to pass the first stage
// TcpListener server = new TcpListener(IPAddress.Any, 6379);
// server.Start();
// server.AcceptSocket(); // wait for client

TcpListener server = new TcpListener(IPAddress.Any,6379);
server.Start();
server.AcceptSocket();

string respondingString = "PONG";
Byte[] sendBytes = Encoding.ASCII.GetBytes(respondingString);
int tmp = server.Send(sendBytes);

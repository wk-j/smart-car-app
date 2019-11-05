#! "netcoreapp2.1"

using System.Net;
using System.Net.Sockets;


System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
clientSocket.Connect("192.168.0.53", 80);

NetworkStream serverStream = clientSocket.GetStream();
serverStream.Write(ASCIIEncoding.ASCII.GetBytes("S\n"));

/*
telnet 192.168.0.53 80
F\n
S\n
R\n
L\n
B\n

Ctl + ] quit
*/

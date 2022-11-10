using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCP_ServerClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 서버 소켓이 동작하는 스레드
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();
            Thread.Sleep(500); // 소켓 서버용 스레드가 실행될 시간을 주기 위해

            // 클라이언트 소켓이 동작하는 스레드
            Thread clientThread = new Thread(clientFunc);
            clientThread.IsBackground = true;
            clientThread.Start();

            Console.WriteLine("종료하려면 아무 키나 누르세요...");
            Console.ReadLine();
        }

        private static void serverFunc(object obj)
        {
            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, 
                                                    SocketType.Stream, 
                                                    ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11200);

                srvSocket.Bind(endPoint);
                srvSocket.Listen(10);           // backlog 큐 연결개수, 클라이언트 동작 개수?

                while (true)
                {
                    Socket clntSocket = srvSocket.Accept();                         // 연결 기다림
                    byte[] recvBytes = new byte[1024];                              // 수신 자리 생성
                    int nRecv = clntSocket.Receive(recvBytes);                      // 수신 개수
                    string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);      // 수신내용(바이트 배열) >> 문자열
                                           // (디코딩할 배열, 0번째부터, 개수)     
                    byte[] sendBytes = Encoding.UTF8.GetBytes("Hello: " + txt);     // 송신내용 >> 바이트 배열
                    clntSocket.Send(sendBytes);                                     // 송신
                    clntSocket.Close();
                }
            }
        }

        private static void clientFunc(object obj)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, 
                                        SocketType.Stream, 
                                        ProtocolType.Tcp);

            EndPoint serverEP = new IPEndPoint(IPAddress.Loopback, 11200);
            socket.Connect(serverEP);                                           // 연결시도

            byte[] buf = Encoding.UTF8.GetBytes(DateTime.Now.ToString());       // 송신문자 바이츠로 변환후 송신
            socket.Send(buf);

            byte[] recvBytes = new byte[1024];                                  // 수신 자리
            int nRecv = socket.Receive(recvBytes);                              // 수신 개수
            string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);          // 수신내용(바이트 배열) >> 문자열
            Console.WriteLine(txt);                     
            socket.Close();

            Console.WriteLine("TCP Client socket: Closed");
        } 
    }
}

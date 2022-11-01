using System;
using System.IO;

namespace Memory_Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] shortByte = BitConverter.GetBytes((short)32000);
            byte[] intByte = BitConverter.GetBytes((1652300));

            // 백업 저장소가 메모리인 스트림
            MemoryStream ms = new MemoryStream();
            
            // 버퍼에서 읽은 데이터를 사용하여 현재 스트림에 바이트 블록을 Write
            // (데이터를 쓸 버퍼, 바이트를 복사하기 시작할 buffer의 바이트 오프셋(0부터 시작), 쓸 최대 바이트 수)
            ms.Write(shortByte, 0, shortByte.Length);
            ms.Write(intByte, 0, intByte.Length);
            
            // 스트림 내의 현재 위치를 가져오거나 설정
            ms.Position = 0;

            // MemoryStream 로부터 short역직렬화
            byte[] outByte = new byte[2];
            ms.Read(outByte, 0, 2);
            int shor = BitConverter.ToInt16(outByte, 0);
            Console.WriteLine(shor);

            // int 역직렬화
            outByte = new byte[4];
            ms.Read(outByte, 0, 4);
            int intre=BitConverter.ToInt32(outByte, 0);
            Console.WriteLine(intre);
        }
    }
}

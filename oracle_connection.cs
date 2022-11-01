using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracle_test02
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*
            패키지설치
            NuGet 패키지 관리자 > 솔루션용 > oracle 검색 > Oracle.ManagedDataAccess 설치
        
          */
        
            // 오라클 연결 문자열        
            //string strConn = "Data Source=orcl;User Id=scott;Password=TIGER;";

            // 네트워크 연결 정보 직접 대입
            string strConn = 
                "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";

            OracleConnection conn = new OracleConnection(strConn);          // 오라클 연결
            conn.Open();

            OracleCommand cmd = new OracleCommand();        // 명령 객체 생성
            cmd.Connection = conn;

            cmd.CommandText = "select * from emp";          // SQL문 지정 및 INSERT 실행
            cmd.ExecuteNonQuery();

            OracleDataReader rdr = cmd.ExecuteReader();     // 결과 리더 객체를 리턴

            // 레코드 계속 가져와서 루핑
            while (rdr.Read())                  // 필드 데이타 읽기
            {
                string ename = rdr["ename"] as string;      // c#에 맞춰 변환
                string job = rdr["job"] as string;
                string sal = rdr["sal"].ToString();         //int sal = rdr.GetInt32(5);    자리수 정하기

                Console.WriteLine($"{ename}:{job}:{sal}");  // 데이타를 리스트박스에 추가
            }
            conn.Close();                       // 사용후 닫음
        }
    }
}

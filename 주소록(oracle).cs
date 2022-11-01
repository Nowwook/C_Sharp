using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1_add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strConn =
               "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            while (true)
            {
                Console.WriteLine("1. 테이블,시퀀스 생성");
                Console.WriteLine("2. 데이터 삽입");
                Console.WriteLine("3. 데이터 조회");
                Console.WriteLine("4. 데이터 수정");
                Console.WriteLine("5. 테이블,시퀀스 삭제");
                Console.Write("메뉴: ");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (n)
                {
                    case 1:
                        cmd.CommandText =
                            "CREATE TABLE ADDR_TABLE(ADDR_ID    NUMBER(4) PRIMARY KEY,NAME    VARCHAR2(20),HP    VARCHAR2(20))";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE SEQUENCE squ_1 " +
                            "INCREMENT BY 1 " +
                            "START WITH 1 " +
                            "MAXVALUE 50 " +
                            "MINVALUE 0" +
                            "CACHE 2 ";
                        cmd.ExecuteNonQuery();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("이름을 입력해 주세요 : ");
                        string a = Console.ReadLine();
                        Console.Write("전화번호를 입력해 주세요 : ");
                        string b = Console.ReadLine();
                        cmd.CommandText = $"INSERT INTO ADDR_TABLE(ADDR_ID,NAME,HP) VALUES(squ_1.nextval,'{a}','{b}')";
                        cmd.ExecuteNonQuery();

                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine($"{"ADDR_ID"}\t\t{"NAME",-15}{"HP",-15}");

                        cmd.CommandText = "select * from ADDR_TABLE";
                        cmd.ExecuteNonQuery();
                        OracleDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            string ADDR_ID = rdr["ADDR_ID"].ToString();
                            string NAME = rdr["NAME"] as string;
                            string HP = rdr["HP"] as string;

                            Console.WriteLine($"{ADDR_ID}\t\t{NAME,-15}{HP,-15}");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("수정할 번호 : ");
                        int d = Int32.Parse(Console.ReadLine());
                        Console.Write("수정할 이름 입력 : ");
                        string a1 = Console.ReadLine();
                        Console.Write("수정할 전화번호 입력 : ");
                        string b1 = Console.ReadLine();
                        cmd.CommandText = $"UPDATE ADDR_TABLE SET NAME='{a1}', HP='{b1}' WHERE ADDR_ID={d}";
                        cmd.ExecuteNonQuery();
                        Console.WriteLine();
                        break;
                    case 5:
                        cmd.CommandText = "drop table ADDR_TABLE";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "DROP SEQUENCE Squ_1";
                        cmd.ExecuteNonQuery();
                        break;
                }
            }
        }
    }
}

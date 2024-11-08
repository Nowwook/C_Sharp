/*
테이블 데이터를 가져와 DataGrid에 넣을 때, 두 가지 주요 방식
DataTable.DefaultView
List<T>
*/

/*
1. DataTable.DefaultView
DataTable.DefaultView는 데이터를 테이블 형식 그대로 유지하면서 사용할 수 있는 방식
테이블 데이터에 대한 필터링, 정렬, 검색 등을 쉽게 지원하는 기능을 제공
DefaultView.RowFilter -  필터링
DefaultView.Sort - 정렬

장점:
필터링 및 정렬 기능 내장
DataTable의 강력한 기능: 여러 테이블을 가져오거나 복잡한 쿼리를 사용할 때 유리
단점:
강타입이 아님: DataTable은 모든 열의 데이터를 object로 처리하므로 컴파일 타임에 타입 체크가 불가능
직관성 부족: 데이터 구조가 List<T>보다 직관적이지 않아서, 코드 유지보수가 어렵거나 복잡

*/
// MSSQL에서 데이터를 DataTable로 가져온 후 DataGrid에 바인딩
DataTable dataTable = new DataTable();
using (SqlConnection conn = new SqlConnection(connectionString))
{
    using (SqlCommand cmd = new SqlCommand("SELECT * FROM YourTable", conn))
    {
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(dataTable);
        conn.Close();
    }
}

// DataGrid에 DefaultView 바인딩
myDataGrid.ItemsSource = dataTable.DefaultView;복사
// 필터링 예시
dataTable.DefaultView.RowFilter = "Age > 25";
// 정렬 예시
dataTable.DefaultView.Sort = "Name ASC";

/*
2. List<T> 사용
List<T>는 MSSQL에서 데이터를 특정 모델 클래스(T)에 매핑하여 사용하는 방식
강타입 사용: List<T>를 사용하면 특정 모델 클래스(T)에 데이터를 매핑하므로 타입 안전성이 보장
객체 지향적인 코드: 각 행이 모델 클래스의 객체로 표현되기 때문에 데이터 접근과 관리가 더 직관적
확장성: 객체에 대해 추가 메서드나 로직을 추가하여 더 복잡한 기능을 쉽게 구현

장점:
타입 안전성: 데이터를 모델 클래스로 매핑하므로 타입에 대한 안전성이 보장
유지보수 용이: 코드가 직관적, IDE에서 데이터 모델의 속성에 대한 자동 완성 기능을 사용할 수 있어 코드 유지보수가 용이
객체 기반 프로그래밍: 데이터를 쉽게 확장하고 조작. 예) List<Person>에서 Person 클래스의 메서드를 호출하거나 속성을 쉽게 조작
단점:
필터링 및 정렬: LINQ와 같은 추가적인 코드가 필요
여러 테이블을 조합하여 사용하는 경우 복잡
*/
// Person 클래스 정의
public class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

// MSSQL에서 데이터를 List로 가져오기
List<Person> people = new List<Person>();
using (SqlConnection conn = new SqlConnection(connectionString))
{
    using (SqlCommand cmd = new SqlCommand("SELECT ID, Name, Age FROM YourTable", conn))
    {
        conn.Open();
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                people.Add(new Person
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Age = reader.GetInt32(2)
                });
            }
        }
        conn.Close();
    }
}

// DataGrid에 List 바인딩
myDataGrid.ItemsSource = people;

// LINQ를 사용한 필터링과 정렬
var filteredList = people.Where(p => p.Age > 25).OrderBy(p => p.Name).ToList();
myDataGrid.ItemsSource = filteredList;

/*
특성	
              DataTable.DefaultView	                                List<T>
데이터 구조	  테이블 형식	                                          객체 지향적인 리스트
타입 안전성	  없음 (object로 처리)	                                  있음 (모델 클래스에 매핑)
필터링/정렬	  내장 기능 (RowFilter, Sort)	                          LINQ와 같은 추가 코드 필요
코드 직관성	  상대적으로 복잡	                                      상대적으로 직관적
데이터베이스   관계 처리	복잡한 쿼리 및 테이블 관계 처리에 유리	        단순한 테이블에 적합
용도	        여러 테이블, 복잡한 쿼리 사용 시 유리	                  단순한 데이터를 객체화할 때 유리

결론:
**DataTable.DefaultView**는 복잡한 쿼리와 필터링/정렬 기능, 데이터베이스에서 가져온 테이블 데이터를 직접 사용
**List<T>**는 객체 지향적,이고 타입 안전한 방식으로 데이터를 관리하고자 할 때 유하며, 데이터의 직관적인 접근과 유지보수성
*/

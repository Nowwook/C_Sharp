/*
DataGrid에서 데이터는 행(Row) 안에 들어감
각 행은 ItemsSource에 바인딩된 데이터 소스의 각 개별 항목
각 열(Column)은 해당 행에서 특정 속성(Property) 값을 표시
데이터는 행(row) 단위로 구성되며, 각 행은 데이터 소스의 항목을 나타내고, 각 열은 해당 항목의 속성을 표현함

DataGrid 구조 요약:
행(Row):
각 행은 데이터 소스의 개별 항목
예) List<Person> 컬렉션이 있으면, 각 Person 객체가 DataGrid의 한 행
데이터는 행 단위로 들어가며, ItemsSource에 설정된 데이터 소스에 따라 자동으로 생성

열(Column):
열은 해당 데이터 항목의 속성
예) Person 객체의 Name 속성이 있으면, 이 속성의 값은 DataGrid의 Name 열에 표시
열은 해당 데이터 항목의 특정 필드나 속성

셀(Cell):
셀은 행과 열의 교차점에서 개별 데이터를 표시합니다.
각 셀은 하나의 행에 있는 특정 속성의 값
*/
// 데이터 흐름 예시:
public class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

// DataGrid의 ItemsSource에 할당되는 데이터
List<Person> people = new List<Person>
{
    new Person { ID = 1, Name = "Alice", Age = 25 },
    new Person { ID = 2, Name = "Bob", Age = 30 },
    new Person { ID = 3, Name = "Charlie", Age = 22 }
};

/*
DataGrid에서의 관계:
행(Row): 각 Person 객체가 하나의 행에 대응.
첫 번째 행: { ID = 1, Name = "Alice", Age = 25 }
두 번째 행: { ID = 2, Name = "Bob", Age = 30 }
세 번째 행: { ID = 3, Name = "Charlie", Age = 22 }

열(Column): Person 객체의 속성(ID, Name, Age)이 각각의 열에 대응.
첫 번째 열: ID
두 번째 열: Name
세 번째 열: Age

셀(Cell): 각 열과 행의 교차점에서 데이터가 표시
첫 번째 셀(1행 1열): 1 (Alice의 ID)
두 번째 셀(1행 2열): Alice (Alice의 이름)
세 번째 셀(1행 3열): 25 (Alice의 나이)


ItemsSource:
DataGrid에 표시될 데이터는 ItemsSource 설정
ItemsSource는 일반적으로 컬렉션(예: List, ObservableCollection) 또는 데이터 테이블(DataTable) 형식으로 설정
이 컬렉션의 각 항목은 DataGrid의 각 행에 매핑

Binding:
각 열은 Binding을 통해 데이터 소스의 특정 속성이나 필드에 연결
DataGridTextColumn은 Binding="{Binding Name}"을 통해 Name 속성을 나타냄
데이터 소스 항목이 변경되면, DataGrid의 해당 셀에 표시된 값도 자동으로 업데이트(특히 ObservableCollection을 사용하면 변경 사항이 실시간으로 반영)

셀(Cell)과 데이터:
셀은 기본적으로 행의 속성값을 시각적으로 표시하는 컨테이너
각 셀은 데이터 소스의 특정 값에 바인딩되며, 이 값을 시각적으로 렌더링

행 추가/삭제:
데이터를 추가하거나 삭제할 때는 ItemsSource 컬렉션에서 해당 항목을 추가 또는 삭제하면 DataGrid가 자동으로 업데이됩니다.
*/

people.Add(new Person { ID = 4, Name = "David", Age = 28 });
people.Remove(people.FirstOrDefault(p => p.ID == 2)); // ID가 2인 항목 삭제

// 편집: 
// 편집 후 데이터를 반영하려면 CellEditEnding 또는 RowEditEnding 이벤트 처리

myDataGrid.CellEditEnding += (sender, e) =>
{
    Person editedPerson = (Person)e.Row.Item; // 편집된 데이터 항목
    // 필요한 로직 처리 (예: 데이터 저장)
};

/*
정렬 및 필터링:
DataGrid는 기본적으로 열 클릭 시 정렬 기능
필터링 기능은 코드로 구현, CollectionView 또는 LINQ
*/
ICollectionView view = CollectionViewSource.GetDefaultView(people);
view.Filter = person => ((Person)person).Age > 25;

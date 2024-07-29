/*
ref 키워드는 변수를 참조 형태로 전달하는데 사용, 변수를 전달하기 전에 변수를 초기화 필수

out 키워드 변수를 참조 형태로 전달하는데 사용 하지만 변수를 전달하기 전에 변수를 초기화 하지 않아도 되고 메서드 안에서는 반드시 할당 필수
*/


public void Num(ref int num)
{
  num = 1;
}

int a = 9;  // 초기화 필수
Num(ref a);
Console.WriteLine(a);	// a 는 1


public void Num(out int num)
{
  num = 1;  // 할당 필수
}

int a ;
Num(out a);
Console.WriteLine(a);	// a 는 1

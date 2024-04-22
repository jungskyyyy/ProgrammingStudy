// 6. IF, Switch 조건문

bool isActive = true;

if (isActive)
{
    Console.WriteLine("작동 중입니다.");
}
else
{
    Console.WriteLine("정지 중입니다.");
}

int number = 5;

// 비교 연산자
if (number == 0) Console.WriteLine("");
else if (number != 0) Console.WriteLine("");
else if (number > 0)  Console.WriteLine("");
else if (number < 0)  Console.WriteLine("");
else if (number >= 0) Console.WriteLine("");
else if (number <= 0) Console.WriteLine("");

// 논리 연산자 AND(&&), OR(||), NOT(!)
if (number == 0 && isActive == true)      Console.WriteLine("");
else if(number == 0 || isActive == false) Console.WriteLine("");
else if(!isActive)                        Console.WriteLine("");

// 번호에 따른 시퀀스 작동
int status = 0;

switch (status)
{
    case 0:
        Console.WriteLine("0번 상태입니다.");
        break;
    case 1:
        Console.WriteLine("1번 상태입니다.");
        break;
    case 2:
        Console.WriteLine("2번 상태입니다.");
        break;
}

// 실습3. PLC 5초 딜레이 신호등을  if문 또는 switch case문으로 작성해 봅니다.
// 조건: status / 적색(0), 황색(1), 녹색(2)
// M10(0), M11(1), M12(2) -> Console.WriteLine("적색 전구 ON");
// Timer -> Console.WriteLine("5초 Timer ON");

for(int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        Console.WriteLine("적색 전구 ON");
    }
    else if (i == 1)
    {
        Console.WriteLine("황색 전구 ON");
    }
    else if (i == 2)
    {
        Console.WriteLine("녹색 전구 ON");
    }

    Console.WriteLine("5초 Timer ON");
}
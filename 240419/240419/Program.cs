// 5. 컬렉션 연습 2


/* Stack 연습
 * Stack<int> numbers = new Stack<int>();
numbers.Push(10);
numbers.Push(100);
numbers.Push(1000);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("----------");

int peekNumber = numbers.Peek();
Console.WriteLine(peekNumber);

bool isExist = numbers.Contains(100);
if (isExist)
    Console.WriteLine("100이 존재합니다.");

int value = numbers.Pop(); // 쌓아올린 값을 순서대로 꺼낸다.
Console.WriteLine(value);

value = numbers.Pop(); // 쌓아올린 값을 순서대로 꺼낸다.
Console.WriteLine(value);

value = numbers.Pop(); // 쌓아올린 값을 순서대로 꺼낸다.
Console.WriteLine(value);*/


/*< 실습 1 - Stack >
작업(파워포인트)을 되돌리기 상태로 만들어주는 예제
1. 특정 횟수만큼 파워포인트 각 작업을 반복해서 넣고(ReadLine)
2. (넣는 과정이 끝나면) 1번 입력(되돌리기 버튼)을 누를 경우
되돌리기 작업의 이름과 현재 진행된 작업의 이름을 Stack에 쌓인 순서대로 출력(Pop)*/

/*Stack<string> tasks = new Stack<string>();
tasks.Push("1. 삽입 메뉴 클릭");
tasks.Push("2. 그림 아이콘 클릭");
tasks.Push("3. 이 장치 선택");
tasks.Push("4. \'고양이\' 이미지 열기");
tasks.Push("5. \'고양이\' 이미지 우클릭");
tasks.Push("6. 애니메이션 추가 클릭");
tasks.Push("7. 나타내기 아이콘 클릭");

foreach(string task in tasks)
{
    Console.WriteLine(task);
}

Console.WriteLine("----------");

for(int i = 0; i < tasks.Count;)
{
    Console.WriteLine("실행할 명령어를 입력해 주세요. 실행 취소(1), 다시 실행(2)");
string input = Console.ReadLine();

    if(input == "1")
    {
        Console.WriteLine("다음 명령을 되돌립니다.");
        Console.WriteLine(tasks.Peek());

        tasks.Pop();

        Console.WriteLine("< task list>");

        foreach(string newTask in tasks)
        {
            Console.WriteLine(newTask);
        }
    }
}*/


/* Queue 연습
 * Queue<string> waitingPeople = new Queue<string>();
waitingPeople.Enqueue("박미소");
waitingPeople.Enqueue("박지현");
waitingPeople.Enqueue("오화정");

foreach (string people in waitingPeople)
{
    Console.WriteLine(people);
}

string name = waitingPeople.Dequeue();
Console.WriteLine(name);

name = waitingPeople.Dequeue();
Console.WriteLine(name);

name = waitingPeople.Dequeue();
Console.WriteLine(name);*/

/* < 실습 2 - Queue >
 * 도서관 대출자 대기열
 * 1. 대출자 대기열에 맞춰 대출자의 이름과 도서의 이름을 대기열(Queue)에 등록
 * 2. 도서관 직원이 대기열에 맞춰 대출 목록에 업데이트 
 * 
 * 입출력 예시
 * "대출자의 이름을 입력해 주세요."
 * 정하늘
 * "대출하려는 도서 권수를 입력해 주세요."
 * 2
 * "대출하려는 도서명을 입력해 주세요."
 * 소설 만세
 * "대출하려는 도서명을 입력해 주세요."
 * 산시로
 * "도서가 등록되었습니다."
 * 
 * Queue에 들어갈 내용 -> 이름: 정하늘\n도서1. 소설 만세\n도서2. 산시로
 * 
 * 이름: 정하늘
 * 도서1. 소설 만세
 * 도서2. 산시로
 */


Queue<string> rentQueue = new Queue<string>();
string queueInfo = "";

Console.WriteLine("대출자의 이름을 입력해 주세요.");
string rentName = "이름: " + Console.ReadLine();

Console.WriteLine("대출하려는 도서 권수를 입력해 주세요.");
string quant = Console.ReadLine();
int rentQuant = int.Parse(quant);

queueInfo = rentName + "\n";

Queue<string> rentBooks = new Queue<string>();
for (int i = 0; i < rentQuant; i++)
{
    Console.WriteLine("대출하려는 도서명을 입력해 주세요.");
    string rentBook = Console.ReadLine();
    queueInfo += "도서" + (i + 1) + ". " + rentBook + "\n";
}


Console.WriteLine("도서가 등록되었습니다.");
Console.WriteLine(queueInfo);

// 최종실습 도서관시스템
// 1. 도서 검색
// 2. 도서 입력
// 3. 도서 반납 리스트
// 4. 대출 리스트
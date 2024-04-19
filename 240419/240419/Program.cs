// 4. 컬렉션 연습

// 배열: 고정형
using System.Data.Common;
using System.Runtime.InteropServices;

string[] names = { "박미소", "박지현", "오화정" };

// 리스트: 가변형
List<string> names2 = new List<string>()
{
    "박미소",
    "박지현",
    "오화정"
};

Console.WriteLine(names[0]);
Console.WriteLine(names2[0]);
names2.Add("정하늘");
Console.WriteLine(names2[3]);

// 배열의 반복
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

// 리스트의 반복
for (int i = 0; i < names2.Count; i++)
{
    Console.WriteLine(names2[i]);
}

// 리스트에서 이름 찾기
int index = names2.IndexOf("오화정");
Console.WriteLine("오화정은 " + index + "번째에 있습니다.");

// 존재 여부 확인
bool isExist = names2.Contains("정하늘");
if (isExist)
    Console.WriteLine("존재합니다.");

// 리스트를 정렬
names2.Sort();
for (int i = 0; i < names2.Count; i++)
{
    Console.WriteLine(names2[i]);
}


// 딕셔너리: "example"(Key), 5번째(Value)
Dictionary<string, int> dictionary =  new Dictionary<string, int>();
dictionary.Add("book", 0);
dictionary.Add("computer", 1);
dictionary.Add("mouse", 2);

index = dictionary["mouse"];
Console.WriteLine("mouse는 " + index + "번째에 있습니다.");
bool isContaining = dictionary.ContainsKey("book");
if (isContaining)
    Console.WriteLine("book이 존재합니다.");

// 실습2 - 도서 검색 서비스
// 도서관에 가로 3칸, 세로 2층의 책꽂이가 있습니다.
// (미리 책꽂이에 책들을 꽂아놓은 상태)
// 특정 책의 이름을 입력받아 책의 일련번호(위치)를 출력하는 책꽂이 시스템을 만드세요.

// 예시
// 도서의 이름을 입력해 주세요.
// _
// 도서의 위치는 (3, 2) 입니다.

// 실행할 명령어를 입력해 주세요. 검색, 추가, 제거
// 검색
// 도서명으로 검색할 수 있습니다.
// _
// 도서 위치는 (3, 2) 입니다.

Dictionary<string, string> library = new Dictionary<string, string>();
library.Add("제인 에어", "0, 0");
library.Add("폭풍의 언덕", "0, 1");
library.Add("오만과 편견", "0, 2");
library.Add("백년의 고독", "1, 0");
library.Add("콜레라 시대의 사랑", "1, 1");
library.Add("8월에 만나요", "1, 2");

Console.WriteLine("실행할 명령어를 입력해주세요.");
Console.WriteLine("검색, 추가, 제거 명령어를 입력할 수 있습니다.");
string command = Console.ReadLine();
string search = "검색";
string add = "추가";
string remove = "제거";

if (command == search)
{
    Console.WriteLine("도서명으로 검색할 수 있습니다.");
    string searchBook = Console.ReadLine();

    bool isContaingSearch = library.ContainsKey(searchBook);

    if (isContaingSearch)
    {
        string searchLocation = library[searchBook];
        Console.WriteLine("도서 위치는 " + searchLocation + " 입니다.");
    };
    if (!isContaingSearch)
        Console.WriteLine("존재하지 않는 도서명입니다.");
}

else if(command == add)
{
    Console.WriteLine("추가할 도서명을 입력해 주세요.");
    string addBook = Console.ReadLine();

    bool isContaingAdd = library.ContainsKey(addBook);

    if (!isContaingAdd)
    {
        Console.WriteLine("도서를 추가할 위치를 입력해 주세요. (0, 0)");
        string addLocation = Console.ReadLine();
        library.Add(addBook, addLocation);
        Console.WriteLine(addBook + " 도서를 " + addLocation + " 에 추가했습니다.");
    }
    if (isContaingAdd)
        Console.WriteLine("이미 추가된 도서명입니다.");
}

else if (command == remove)
{
    Console.WriteLine("삭제할 도서명을 입력해 주세요.");
    string removeBook = Console.ReadLine();

    bool isContaingRemove = library.ContainsKey(removeBook);
    if (isContaingRemove)
    {
        library.Remove(removeBook);
        Console.WriteLine(removeBook + " 도서를 삭제했습니다.");
    }
    if (!isContaingRemove)
        Console.WriteLine("존재하지 않는 도서명입니다.");
}

else
{
    Console.WriteLine("유효하지 않은 명령어입니다.");
}
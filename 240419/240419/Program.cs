// 7. 시간지연

Console.WriteLine("시작");

Thread.Sleep(3000);

Console.WriteLine("종료");

// 실습
// 도서 관리 시스템
// 기능1. 도서등록 -> "동물농장" "3,1" 입력 -> Dictionary<string, string> library에 저장
// 기능2. 도서검색 -> "동물농장" 검색 -> 위치(3,1) 출력 -> library 사용 검색
// 기능3. 회원등록 -> "회원명", "회원번호(임의의 번호)" -> Dictionary<string, int> members에 저장
// 기능4. 대출예약 -> 도서검색(빌려간 책)인 경우 "이름", "책이름" Queue에 저장 -> Queue<string> waitings

//입출력예시
// 번호를 선택해 주세요. (0. 도서등록, 1: 도서검색, 2: 회원등록. 3: 대출예약)
// 0
// 도서명을 입력해 주세요.
// 동물농장
// 도서 위치를 입력해 주세요.
// 3,1
// 등록이 완료되었습니다. 동물농장(3,1)

// 번호를 선택해 주세요. (0. 도서등록, 1: 도서검색, 2: 회원등록. 3: 대출예약)
// 1
// 도서명을 입력해 주세요.
// 동물농장
// 동물농장은 3,1에 있습니다.

// 번호를 선택해 주세요. (0. 도서등록, 1: 도서검색, 2: 회원등록. 3: 대출예약)
// 2
// 회원등록 페이지입니다. 회원명을 입력해 주세요.
// 정하늘
// 비밀번호를 입력해 주세요.
// 1234
// 회원등록이 완료되었습니다.

// 번호를 선택해 주세요. (0. 도서등록, 1: 도서검색, 2: 회원등록. 3: 대출예약)
// 3
// 대출예약을 위해 회원명을 입력해 주세요.
// 정하늘
// 도서명을 입력해 주세요.
// 동물농장
// 비밀번호를 입력해 주세요.
// 1234
// 예약되었습니다.

Dictionary<string, string> library = new Dictionary<string, string>();
Dictionary<string, int> memberList = new Dictionary<string, int>();
Queue<string> reservation = new Queue<string>();

while (true)
{
    Console.WriteLine("번호를 선택해 주세요. (0. 도서등록, 1: 도서검색, 2: 회원등록. 3: 대출예약)");
    string status = Console.ReadLine();

    switch (status)
    {
        case "0":
            RegisterBook();
            break;
        case "1":
            SearchBook();
            break;
        case "2":
            ResisterMember();
            break;
        case "3":
            MakeReservation();
            break;
        default:
            Console.WriteLine("번호를 확인해 주세요.");
            break;
    }
}

void RegisterBook()
{
    Console.WriteLine("도서명을 입력해 주세요.");
    string bookName = Console.ReadLine();

    Console.WriteLine("도서 위치를 입력해 주세요.");
    string bookLocation = Console.ReadLine();

    library.Add(bookName, bookLocation);

    Console.WriteLine("도서등록이 완료되었습니다. " + bookName + " ( " + bookLocation + " )");
}

void SearchBook()
{
    Console.WriteLine("도서명을 입력해 주세요.");
    string bookName = Console.ReadLine();

    bool isExist = library.ContainsKey(bookName);

    if (isExist) Console.WriteLine("도서 위치는 " + library[bookName] + " 입니다.");
    else Console.WriteLine("도서를 찾을 수 없습니다.");
}

void ResisterMember()
{
    Console.WriteLine("회원등록 페이지입니다. 회원명을 입력해 주세요.");
    string memberName = Console.ReadLine();


    Console.WriteLine("비밀번호를 입력해 주세요.");
    string memberPw = Console.ReadLine();
    int memberPassword = int.Parse(memberPw);

    memberList.Add(memberName, memberPassword);
    Console.WriteLine(memberName + " 님 회원등록이 완료되었습니다.");
}

void MakeReservation()
{
    Console.WriteLine("대출예약을 위해 회원명을 입력해 주세요.");
    string reserveName = Console.ReadLine();

    bool isExist = memberList.ContainsKey(reserveName);
    if (isExist)
    {
        Console.WriteLine("도서명을 입력해 주세요.");
        string bookName = Console.ReadLine();

        bool isContain = library.ContainsKey(bookName);

        if (isContain)
        {
            Console.WriteLine("비밀번호를 입력해 주세요.");
            string memberPw = Console.ReadLine();
            int memberPassword = int.Parse(memberPw);

            bool isVerified = memberList[reserveName] == memberPassword;

            if (isVerified)
            {
                reservation.Enqueue(reserveName + ", " + bookName);
                Console.WriteLine(reserveName + " 님의 " + bookName + " 도서 대출예약이 완료되었습니다.");
            }

            else Console.WriteLine("비밀번호를 확인해 주세요.");
        }

        else Console.WriteLine("도서를 찾을 수 없습니다.");
    }

    else
    {
        Console.WriteLine("회원을 찾을 수 없습니다.");
    }
}
// 10. 클래스

using static MainClass;

public class MainClass
{
    // Person Class Template
    public class Person
    {
        // 필드 or 멤버변수 or 전역변수, Global Variable
        public string name;
        public int age;
        public int id;

        // 생성자 Contructor: 인스턴싱 시 필드 초기화 or 메서드 실행
        public Person(string _name, int _age, int _id)
        {
            name = _name;
            age = _age;
            id = _id;

            Introduce();
        }

        public Person()
        {
            Introduce();
        }

        // 함수 X -> 메서드 O
        public void Introduce()
        {
            // 지역변수, Local Variable
            /*int number = 10;
            number = 20;
            this.name = "홍길동"; // 전역변수 name 사용*/
            Console.WriteLine("저는 " + this.name + "입니다.");

            // string name = "정하늘";
            // Console.WriteLine(name); // 지역변수 name 사용
        }

        public void Move()
        {

        }
    }


    public static void Main()
    {
        Person person1 = new Person(); // Instancing, 인스턴스화, 객체화, 메모리 할당
        // person1.name = "정하늘"; // 변수의 초기화, Variable Initialization
        // person1.Introduce();

        // 실습5. 클래스 생성자를 사용하여 5명의 사람 클래스 인스턴싱 해봅니다.
        Person person2 = new Person("정하늘", 29, 1);
        Person person3 = new Person("정한일", 27, 2);
        Person person4 = new Person("정성일", 33, 3);
        Person person5 = new Person("정일", 35, 4);
        Person person6 = new Person("정기봉", 62, 5);

        List<string> bookList = new List<string>();
        List<Person> personList = new List<Person>();

        // 실습7. 아래의 내용으로 도서 클래스 만들고, 라이브러리(Dictionary)에 도서 3권 저장
        // 도서명, 저자, 출판사, 일련번호, 출판일, 도서관 내 위치, 도서 대여여부, ... 
        Book book1 = new Book("소설 만세", "0,1");
        Book book2 = new Book("거미여인의 키스", "0,2");
        List<Book> books = new List<Book>();
        books.Add(book1);
        books.Add(book2);

        bool isExsist = books.Contains(new Book("소설 만세", ""));
        if (isExsist)
            Console.WriteLine("존재합니다.");

        Book bookFound = books.Find(x => x.name.Contains("소설 만세"));
        Console.WriteLine("이름: " + bookFound.name + " / 위치: " + bookFound.location);

        // 실슬8. 도서 등록 시스템 구성
        List<Book> books2 = new List<Book>();
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("도서를 등록합니다.");

            int statusNumber = 7;
            Book book = new Book();

            for (int status = 0; status < statusNumber; status++)
            {
                string input = "";

                switch (status)
                {
                    case 0:
                        Console.WriteLine("도서명을 입력해 주세요.");
                        input = Console.ReadLine();
                        book.name = input;
                        break;
                    case 1:
                        Console.WriteLine("저자명을 입력해 주세요.");
                        input = Console.ReadLine();
                        book.author = input;
                        break;
                    case 2:
                        Console.WriteLine("출판사를 입력해 주세요.");
                        input = Console.ReadLine();
                        book.company = input;
                        break;
                    case 3:
                        Console.WriteLine("일련번호를 입력해 주세요.");
                        input = Console.ReadLine();
                        book.serialNumber = int.Parse(input);
                        break;
                    case 4:
                        Console.WriteLine("출판일을 입력해 주세요.");
                        input = Console.ReadLine();
                        book.publicationDate = DateTime.Now;
                        break;
                    case 5:
                        Console.WriteLine("도서 위치를 입력해 주세요.");
                        input = Console.ReadLine();
                        book.location = input;
                        break;
                    case 6:
                        Console.WriteLine("대여 상태을 입력해 주세요.");
                        input = Console.ReadLine();
                        book.isRent = bool.Parse(input);
                        break;
                    case 10:
                        isRunning = false;
                        break;
                }
            }
            book.ShowInformation();
            book.ShowInformation(1, DateTime.Now);
            string returnValue = book.ShowInformation(4);
            Console.WriteLine(returnValue);



            books2.Add(book);
            Console.WriteLine("도서 등록이 완료되었습니다.");
        }
        
        // 도서명을 입력해 주세요.
        // 파우스트
        // 도서 위치를 입력해 주세요.
        // 1,1
        // 1번 눌러서 도서 검색 (도서명 또는 위치 검색)
        // (파우스트, 1,1) 도서 정보 출력
    }

    // 1. 객체 생성 용도
    // 2. 데이터 저장용 컨테이너 용도
    public class Book
    {
        public string name;                 // 1
        public string author;               // 2
        public string company;              // 3
        public int serialNumber;            // 4
        public DateTime publicationDate;    // 5
        public string location;             // 6
        public bool isRent;                 // 7

        public Book(string name, string author, string company, int serialNumber, DateTime publicationDate, string location, bool isRent)
        {
            this.name = name;
            this.author = author;
            this.company = company;
            this.serialNumber = serialNumber;
            this.publicationDate = publicationDate;
            this.location = location;
            this.isRent = isRent;
        }

        public Book(String name, string location)
        {
            this.name = name;
            this.location = location;
        }
        public Book()
        {

        }

        public void ShowInformation()
        {
            Console.WriteLine($"{this.name}, {this.author}, {this.company}, {this.publicationDate}, {this.location}, {this.isRent}");
        }

        // 함수의 오버로드
        // 접근제어자 리턴타입 함수의 이름(매개변수 or 인자 or 파라메터)
        public void ShowInformation(int number, DateTime dateTime)
        {
            Console.WriteLine("리턴타입 없음");
        }

        public string ShowInformation(int name)
        {
            string result = "리턴타입 있음";

            return result;
        }
    }
}
// 8. 열거형

//  열거형 포맷 정의
enum Option
{
    ResisterBook = 5,
    SearchBook,
    ResisterMember,
    SearchMeber,
    MakeReservation
}

public class Student
{
    public static void Main()
    {
        // 사용을 위해 선언
        Option op = Option.ResisterBook;

        switch (op)
        {
            case Option.ResisterBook:
                break;
            case Option.SearchBook:
                break;
            case Option.ResisterMember:
                break;
            case Option.MakeReservation:
                break;
        }

        if (op == Option.RegisterBook)
        {

        }
    }
}
// 12. 스태틱(static, 정적) 클래스
// 변함이 없는 클래스
// 게시판에 있어서 모든 사람들이 알고 있는 클래스
// new 키워드로 메모리 할당이 필요 없는 클래스

public static class Calculator
{
    public static float Add(float inputA, float inputB)
    {
        return inputA + inputB;
    }
}

public static class Util
{
    // 정렬 알고리즘,  길찾기 알고리즘
    public static float Add(float inputA, float inputB)
    {
        return inputA + inputB;
    }
}

public class MainClass
{
    public static void Main()
    {
        float numberA = 10.5f;
        float numberB = 5f;

        float result = Calculator.Add(numberA, numberB);
        Console.WriteLine(result);
    }
}

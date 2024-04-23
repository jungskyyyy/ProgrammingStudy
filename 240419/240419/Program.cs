// 11. 클래스 메서드 연습

public class MainClass
{
    public class Calculator
    {
        float inputA = 0, inputB = 0;

        public float Add(float _inputA, float _inputB)
        {
            return _inputA + _inputB;
        }
        public float Subtract(float _inputA, float _inputB)
        {
            return _inputA - _inputB;
        }
        public float Multiply(float _inputA, float _inputB)
        {
            return _inputA * _inputB;
        }
        public float Devide(float _inputA, float _inputB)
        {
            return _inputA / _inputB;
        }
        public float Sin(float _input)
        {
            return MathF.Sin(_input * float.Pi / 180);
        }
        public float Cos(float _input)
        {
            return MathF.Cos(_input * float.Pi / 180);
        }
        public float Tan(float _input)
        {
            return MathF.Tan(_input * float.Pi / 180);
        }
    }
    public static void Main()
    {
        // 실습9. 공학용 계산기의 삼각함수 기능을 Calculator 클래스의 메서드를 사용하여 만들어본다.
        // 1. Calculator를 만든다.
        // 2. Calculator 클래스에 입출력을 위한 변수를 선언한다.
        // 3. Calculator 클래스에 아래와 같은 메서드를 만든다.
        // 메서드 명: Add, Subtract, Multiply, Devide, Sin, Cos, Tan(MathF 클래스를 참고)

        Calculator calculator = new Calculator();

        Console.WriteLine("첫 번째 숫자를 입력해 주세요.");
        string inputA = Console.ReadLine();
        float numberA = float.Parse(inputA);

        Console.WriteLine("연산자(_, -, *, /) 또는 삼각함수(sin, cos, tan)를 입력해 주세요.");
        string oper = Console.ReadLine();

        float result = 0;

        if (oper == "sin" ||  oper == "cos" || oper == "tan")
        {
            switch (oper)
            {
                case "sin":
                    result = calculator.Sin(numberA);
                    break;
                case "cos":
                    result = calculator.Cos(numberA);
                    break;
                case "tan":
                    result = calculator.Tan(numberA);
                    break;
            }

            Console.WriteLine("Result: " + result);
            return;
        }

        Console.WriteLine("두 번째 숫자를 입력해 주세요.");
        string inputB = Console.ReadLine();
        float numberB = float.Parse(inputB);

        switch (oper)
        {
            case "+":
                result = calculator.Add(numberA, numberB);
                break;
            case "-":
                result = calculator.Subtract(numberA, numberB);
                break;
            case "*":
                result = calculator.Multiply(numberA, numberB);
                break;
            case "/":
                result = calculator.Devide(numberA, numberB);
                break;
        }

        Console.WriteLine("Result: " + result);
    }
}

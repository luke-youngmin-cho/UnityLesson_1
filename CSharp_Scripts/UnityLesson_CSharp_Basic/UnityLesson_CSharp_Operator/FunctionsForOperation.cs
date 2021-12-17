namespace UnityLesson_CSharp_Operator
{
    class FunctionsForOperation
    {
        // 산술연산
        //=================================================================
        // 덧셈
        static public int Sum(int a, int b)
        {
            return a + b;
        }
        static public int Sub(int a, int b)
        {
            return a - b;
        }
        static public int Div(int a, int b)
        {
            return a / b;
        }
        static public int Mul(int a, int b)
        {
            return a * b;
        }
        static public int Mod(int a, int b)
        {
            return a % b;
        }

        // 증감연산
        static public int Increase(int a)
        {
            return a++;
        }
        static public int Decrease(int a)
        {
            return a--;
        }

        // 관계연산
        static public bool IsSame(int a, int b)
        {
            return a == b;
        }
        static public bool IsDiffrent(int a, int b)
        {
            return a != b;
        }
        static public bool IsBiffer(int a, int b)
        {
            return a > b;
        }
        static public bool IsSmaller(int a, int b)
        {
            return a < b;
        }
        static public bool IsBiggerOrSame(int a, int b)
        {
            return a >= b;
        }
        static public bool IsSmallerOrSame(int a, int b)
        {
            return a <= b;
        }

        // 대입연산 
        static public int PlusBToA(int a, int b)
        {
            a += b;
            return a;
        }
        static public int MinusBToA(int a, int b)
        {
            a -= b;
            return a;
        }
        static public int MultiplyBToA(int a, int b)
        {
            a *= b;
            return a;
        }
        static public int DivideBToA(int a, int b)
        {
            a /= b;
            return a;
        }
        static public int ModBToA(int a, int b)
        {
            a %= b;
            return a;
        }

        // 논리연산
        static public bool LogicOR(bool a, bool b)
        {
            return a | b;
        }
        static public bool LogicAND(bool a, bool b)
        {
            return a & b;
        }
        static public bool LogicXOR(bool a, bool b)
        {
            return a ^ b;
        }
        static public bool LogicNot(bool a)
        {
            return !a;
        }
        // 조건부 논리연산
        static public bool ConditionalLogicOR(bool a, bool b)
        {
            return a || b;
        }
        static public bool ConditionalLogicAND(bool a, bool b)
        {
            return a && b;
        }

        // 비트 연산
        static public int BitLogicOR(int a, int b)
        {
            return a | b;
        }
        static public int BitLogicAND(int a, int b)
        {
            return a & b;
        }
        static public int BitLogicXOR(int a, int b)
        {
            return a ^ b;
        }
        static public int BitLogicNot(int a)
        {
            return ~a;
        }
        static public int BitShiftLeft(int a, int howManyBitWantYouToShift)
        {
            return a << howManyBitWantYouToShift;
        }
        static public int BitShiftRight(int a, int howManyBitWantYouToShift)
        {
            return a >> howManyBitWantYouToShift;
        }
    }
}

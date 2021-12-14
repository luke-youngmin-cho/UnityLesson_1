﻿using System;

namespace UnityLesson_CSharp_IF
{
    class Program
    {
        static bool condition1 = true;
        static bool condition2 = true;
        static bool condition3 = true;
        static void Main(string[] args)
        {
            if (condition1)
            {
                Console.WriteLine("조건1이 참");
            }
            else if (condition2)
            {
                Console.WriteLine("조건1이 거짓, 조건2가 참");
            }
            else if (condition3)
            {
                Console.WriteLine("조건1과 2가 거짓, 조건 3이 참");
            }
            else
            {
                Console.WriteLine("조건 1,2,3 모두 거짓");
            }
            // 만약에 소괄호 안의 조건이 참이면 중괄호 안의 내용을 실행한다.
            /*if (조건1)
            {
                조건1이 참일때 실행할 내용
            }
            else if(조건2)
            {
                조건1이 거짓이고 조건2가 참일때 실행할 내용
            }
            else if (조건3)
            {
                조건1, 조건2가 거짓이고 조건 3이 참일때 실행할 내용
            }
            else
            {
                조건1, 조건2, 조건3 모두 거짓일 경우 실행할 내용.
            }*/

        }
    }
}

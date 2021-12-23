﻿using System;

namespace UnityLesson_CSharp_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 문의 구조
            //while (조건)
            //{
            //    조건이 참이면 반복할 내용.
            //}

            // 무한 루프 (while 문의 조건이 항상 참일 경우)
            //while (true)
            //{
            //}
            // while 문은 조건이 항상 참이면 무한으로 돌아가기때문에 
            // 프로그램이 멈추는 현상이 발생한다.
            // 그래서 반드시 while 문은 탈출할 수 있는 조건을 입력해야한다.
            // 왠만하면 while 문은 쓰지 않는다. 

            // while 뿐만 아니라 모든 반복문, 분기문은 함수 내에서만 사용가능하다.

            string[] arr_PersonName = new string[3];
            arr_PersonName[0] = "김아무개";
            arr_PersonName[1] = "이아무개";
            arr_PersonName[2] = "박아무개";

            int length = arr_PersonName.Length;
            int count = 0;
            while (count < length)
            {
                Console.WriteLine(arr_PersonName[count]);
                count++;
            }

            //break 를 사용한 while 문 탈출방법
            while (true)
            {
                if(count < length)
                {
                    Console.WriteLine(arr_PersonName[count]);
                }
                else
                {
                    break;
                }
                count++;
            }
        }
    }
}

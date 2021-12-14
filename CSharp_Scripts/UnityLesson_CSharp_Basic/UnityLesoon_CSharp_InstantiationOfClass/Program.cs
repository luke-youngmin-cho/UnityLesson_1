﻿using System;

namespace UnityLesoon_CSharp_InstantiationOfClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            //. 점연산자 
            // 클래스의 멤버에 접근할때 사용, namespace 안의 클래스에 접근할때 사용.
            person1.age = 40; // 정수형은 그냥 숫자 입력
            person1.height = 223.4f; // 실수형은 숫자 뒤에 f 추가 입력
            person1.isFemale = false; // 논리형은 true 또는 false
            person1.genderChar = '남'; // 문자형은 '' 작은 따옴표 안에 단일 문자
            person1.name = "김아무개"; // 문자열형은 "" 큰 따옴표 안에 다중문자

            person1.SayAllInfo();

            Person person2 = new Person();
            person2.age = 80; // 정수형은 그냥 숫자 입력
            person2.height = 123.4f; // 실수형은 숫자 뒤에 f 추가 입력
            person2.isFemale = true; // 논리형은 true 또는 false
            person2.genderChar = '여'; // 문자형은 '' 작은 따옴표 안에 단일 문자
            person2.name = "이아무개"; // 문자열형은 "" 큰 따옴표 안에 다중문자

            person2.SayName();
        }
    }

    class Person
    {
        // 접근제한자
        // 위치 : 자료형 앞
        // 아무것도 안써있으면 기본적으로 private 
        // public , private, protected 가 있다.
        //
        // public : 다른 클래스에서 접근 가능하다.
        // private : 다른 클래스에서 접근이 불가능하다.
        // protected : 상속자만 접근이 가능하다.


        public int age; // 정수형 , 4byte -2147483648~2147483647
        public float height; // 실수형 , 4byte
        public bool isFemale; // 논리형 (참과 거짓), 1 byte
        public char genderChar; // 문자형, 2 byte
        public string name; //문자열 , 문자갯수 * 2byte

        // 이 사람에 대한 모든 정보를 말한다
        public void SayAllInfo()
        {
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }
        public void SayAge()
        {
            Console.WriteLine(age);
        }
        public void SayHeight()
        {
            Console.WriteLine(height);
        }
        public void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        public void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        public void SayName()
        {
            Console.WriteLine(name);
        }
    }
}

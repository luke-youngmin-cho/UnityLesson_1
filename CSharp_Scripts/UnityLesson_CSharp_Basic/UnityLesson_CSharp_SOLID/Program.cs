﻿using System;

// SOLID 원칙 
// 객체지향 프로그래밍을 할때 반드시 지켜주어야 하는 5가지 원칙
// 1. SRP ( Single Responsibility Principle, 단일 책임 원칙 )
// 한 클래스는 하나의 책임만 가져야 함. 여러가지 기능이나 개념을 한 클래스에 다 넣으면
// 수정하기도 불편하고 각 클래스에 대한 확장성, 가독성이 떨어짐. 
//
// 2. OCP ( Open Close Principle , 개방폐쇄의 원칙 )
// 재사용 가능하고 관리하기 편한 코드를 만들기 위한 원칙. 
// 컴포넌트, 클래스, 모듈, 함수 의 확장에는 열려있고, 변경에는 닫혀있어야한다.
// -> 레고 블록을 처음에 다양하고 정확하게 설계해서 , 레고끼리 조립했을때 다양한 작품을 
// 만들수 있도록 한다. 
// 조립 도중에 레고블록이 잘 안맞는다고 해서 레고블록 자체를 자르거나 불로 녹이는 등의 
// 행위를 하면 안된다.
//
// 3. LSP ( The Liskov Substitution Principle , 리스코프 치환 법칙 )
// 하위 타입은 기반타입으로 언제든지 교체할 수 있어야 한다. 
// 1) 두 객체가 똑같은 일을 수행한다
//         -> 클래스는 하나로 만들고,각 객체를 구분지을 수 있는 변수를 멤버로 넣는다.
// 2) 기능 이름이 같고 동작은 비슷하나 약간의 차이가 있다면
//          -> 인터페이스를 구현하고 공통으로 상속 받는다.
// 3) 같은 기능을 가지지 않는다면 두 객체는 각각 별개의 클래스로 구현함.
// 4) 추가적인 기능을 부여해야 할때는 상속을 이용한다.
//
// 4. ISP ( Interface Sergregation Principle , 인터페이스 분리 원칙 )
// 사용 하지 않을 인터페이스는 구현하면 안되고,
// 하나의 일반적인 인터페이스 보다 여러개의 구체적인 인터페이스를 추구함.
// IPointerEvent 라는 인터페이스보다 IPointerDownEvent, IPointerUpEvent, IPointerClickEvent 등으로 세분화 하는것이 좋다.
//
// 5. DIP ( Dependency Inversion Principle, 의존성 역전의 원칙 )
// Caller 호출 하는쪽
// Callee 호출 받는쪽
// Caller 는 Callee 의 인터페이스 함수를 호출함.
// 역할 이름만 보면 Callee 는 Caller 를 호출하면 원칙에 어긋나는것 처럼 보이지만, 
// 상황에따라서 Callee 의 정보를 Caller 에게 줘야할 경우가 많기때문에 
// 이런경우 Callee 도 Caller 의 멤버를 호출할 수 있다고 하는 원칙.
// XX카드사를 Caller , 카드사용자를 Callee 라고 했을때 
// XX카드사에서 카드 사용자에게 전화를 하는것에는 문제가 없음. 
// 사용자가 XX카드사에 전화를 걸때는  무작정 걸수가 없고, 개인정보보호나 본인확인 문제 때문에
// 사용자의 신분을 확인할수 있는 주민번호앞자리, 계좌번호 등을 요구함. 
// 이때 사용자가 다이얼을 눌러서 개인정보를 Caller 인 XX카드사에 등록해주는데, 
// 이 등록해주는 과정이 DIP가 적용되는 경우.  (의존성이 역전된 경우)
// 함수로 따지면
// Callee 객체 Caller.Register(주민번호, 계좌번호); 를 호출한 셈.


namespace UnityLesson_CSharp_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    
}
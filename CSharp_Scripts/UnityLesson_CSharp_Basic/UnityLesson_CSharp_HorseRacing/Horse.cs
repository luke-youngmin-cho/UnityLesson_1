﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
말은
이름, 달린거리 를 멤버변수로
달리기 를 멤버 함수로 가짐.
달리기 멤버함수는 입력받은 거리를 달린거리에 더해주어서 달린거리를 누적시키는 역할을 함.
*/
namespace UnityLesson_CSharp_HorseRacing
{
    class Horse
    {
        public string name; // 이름
        public int distance; // 달린 거리
        public bool dontMove; // 움직이지마!

        // moveDistance 만큼 달린 거리를 증가시켜주는 함수
        public void Run(int moveDistance) 
        {
            distance += moveDistance; 
        }
    }
}

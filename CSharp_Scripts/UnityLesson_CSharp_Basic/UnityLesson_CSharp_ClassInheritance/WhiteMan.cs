using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLesson_CSharp_ClassInheritance
{
    class WhiteMan : Person
    {
        public override void Breath()
        {
            lifeTime++;
            height += 0.00008f;
            weight += 0.00004f;
        }
    }
}

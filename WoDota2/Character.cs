using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WoDota2
{
    public class Character
    {
        public int HPP;
        public int MPP;
        public int DMG;
        public Character target;
        public void Attack()
        {
            target.HPP -= DMG;
        }
    }
}

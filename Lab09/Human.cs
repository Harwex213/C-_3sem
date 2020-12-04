using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Human : Game, IGameObject
    {
        public int HP { get; set; } = 110;
        public int AttackPower { get; set; } = 60;
        public WeaponType Weapon { get; set; } = WeaponType.Sword;
    }
}

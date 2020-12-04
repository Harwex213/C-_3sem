using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Elf : Game, IGameObject
    {
        public int HP { get; set; } = 70;
        public int AttackPower { get; set; } = 100;
        public WeaponType Weapon { get; set; } = WeaponType.Bow;
    }
}

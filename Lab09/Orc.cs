using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Orc : Game, IGameObject
    {
        public int HP { get; set; } = 175;
        public int AttackPower { get; set; } = 110;
        public WeaponType Weapon { get; set; } = WeaponType.Axe;
    }
}

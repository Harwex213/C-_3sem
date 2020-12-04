using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    enum WeaponType
    {
        Axe = 25,
        Bow = 45,
        Sword = 30
    }
    interface IGameObject
    {
        int HP { get; set; }
        int AttackPower { get; set; }
        WeaponType Weapon { get; set; }
    }
}

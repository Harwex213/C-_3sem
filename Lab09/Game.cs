using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Game
    {
        public delegate void GameHandler(IGameObject obj);

        public event GameHandler Attack;
        public event GameHandler Heal;

        public void SeeSomeBody(IGameObject someBody)
        {
            switch (this)
            {
                case Orc _:
                    switch (someBody)
                    {
                        case Orc _:
                            Heal?.Invoke(someBody);
                            break;
                        case Human _:
                            Attack?.Invoke(someBody);
                            break;
                        case Elf _:
                            Attack?.Invoke(someBody);
                            break;
                    }
                    break;
                case Human _:
                    switch (someBody)
                    {
                        case Orc _:
                            Attack?.Invoke(someBody);
                            break;
                        case Human _:
                            Heal?.Invoke(someBody);
                            break;
                        case Elf _:
                            Attack?.Invoke(someBody);
                            break;
                    }
                    break;
                case Elf _:
                    switch (someBody)
                    {
                        case Orc _:
                            Attack?.Invoke(someBody);
                            break;
                        case Human _:
                            Heal?.Invoke(someBody);
                            break;
                        case Elf _:
                            Heal?.Invoke(someBody);
                            break;
                    }
                    break;
            }
        }
    }
}

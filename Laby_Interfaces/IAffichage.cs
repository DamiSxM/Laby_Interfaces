using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laby_Interfaces
{
    public delegate void Position(int x, int y);
    public interface IAffichage
    {
        event Position PositionChanged;
        void PersoMove(Direction d);
        void PersoTeleport(int x, int y);

        void PlayerAdd(string ip, int x, int y);
        void PlayerMove(string ip, int x, int y);
        void PlayerRemove(string ip);

        void ItemAdd(int x, int y, string nom);
        void ItemRemove(int x, int y);

        void Warfog(int lvl);
    }
}

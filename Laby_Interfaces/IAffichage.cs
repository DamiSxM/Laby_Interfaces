using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laby_Interfaces
{
    public delegate void Position(int x, int y);
    public interface IAffichage
    {
        event Position PositionChanged;

        void LabyUpdate();
        void Debug(string message);

        Point PersoGetPosition();
        //void PersoMove(Direction d);
        void PersoMoveLeft();
        void PersoMoveUp();
        void PersoMoveRight();
        void PersoMoveDown();
        void PersoTeleport(Point p);

        bool PlayerExists(string ip);
        void PlayerAdd(string ip, Point p);
        void PlayerMove(string ip, Point p);
        void PlayerRemove(string ip);

        void ItemsInit(Hashtable ht);
        void ItemAdd(Point p, string nom);
        void ItemRemove(Point p);

        void Warfog(int lvl);
    }
}

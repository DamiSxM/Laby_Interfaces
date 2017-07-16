using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Laby_Interfaces
namespace Labyrinthe
{
    public enum Loot
    {
        CRATE, COIN
    };
    public delegate void Position(int x, int y);
    public interface IAffichage
    {
        event Position PositionChanged;

        void LabyUpdate();
        int GetCellSize();

        void Debug(string message);

        Point PersoGetPosition();
        Point PersoGetPositionPixel();

        void PersoMove(Direction d, int vitesse);
        void PersoTeleport(Point p);

        bool PlayerExists(string ip);
        void PlayerAdd(string ip, Point p);
        void PersoMove(Direction d, Point p);
        void PlayerMove(string ip, Point p);
        void PlayerRemove(string ip);

        void ItemsInit(Hashtable ht);
        void ItemAdd(Point p, Loot nom);
        void ItemRemove(Point p);

        void WarfogSet(int lvl);
        int WarfogGet();
    }
}

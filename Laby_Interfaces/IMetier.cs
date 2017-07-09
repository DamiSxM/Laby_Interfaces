using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Laby_Interfaces
namespace Labyrinthe
{
    public enum Direction
    {
        LEFT, UP, RIGHT, DOWN
    };
    public interface IMetier
    {
        void PersoMove(Direction d);
    }
}

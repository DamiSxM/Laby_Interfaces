using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laby_Interfaces
{
    public delegate void RechercheServer(bool isserver);
    public delegate void DataReceive(string sender, object data);
    public interface ILiaison
    {
        event RechercheServer FinRechercheServer;
        event DataReceive DataReceived;
        void SendData(object data);
    }
}

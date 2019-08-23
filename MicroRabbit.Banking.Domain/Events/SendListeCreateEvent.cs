using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Events
{
    class SendListeCreateEvent
    {
        public int Filiale_ID { get; set; }
       
        public string Nom_Filiale { get; set; }
        public string Code_Filiale { get; set; }
        public SendListeCreateEvent(int filiale_ID, string nom_Filiale, string code_Filiale)
        {
            Filiale_ID = filiale_ID;
            Nom_Filiale = nom_Filiale;
            Code_Filiale = code_Filiale;
        }
    }
}

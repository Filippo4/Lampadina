using System;

namespace ClassiDellaLampadina
{
    public class Lampadina
    {
        public const int ACCESO = 0;
        public const int SPENTO = 1;
        public const int ROTTO = -1;
        private const int MAXCLICK = 50;
        private int stato = SPENTO;
        private int cliclAttuali = 0;
        public Lampadina()
        {

        }
        public int Click()
        {
            if (stato != ROTTO)
            {
                cliclAttuali++;
                if (cliclAttuali >= MAXCLICK)
                {
                    return stato = ROTTO;
                }
                else
                {
                    stato = 1 - stato;
                }
            }
            return stato;
        }
        public string StatoAttuale()
        {
            
            if (stato == SPENTO)
                return "la lampadina è spenta!";
            else if (stato == ACCESO)
                return "la lampadina è accesa";
            else
                return "la lampadina è rotta";
        }
    }
}

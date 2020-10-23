using System;
//Mark Maglio

namespace Lampadina
{
    public class Lampadina
    {
        public const int STATO_SPENTA = 0;
        public const int STATO_ACCESA = 1;
        public const int STATO_ROTTA = -1;
        private const int CLICK_PRIMA_DI_ROTTURA = 40;

        private int stato = STATO_SPENTA;
        private int NumeroClick = 0;

        public Lampadina() { }

        public int Click()
        {
            NumeroClick++;
            if (NumeroClick >= CLICK_PRIMA_DI_ROTTURA)
                stato = STATO_ROTTA;
            else
            {
                if (stato == STATO_SPENTA)
                    stato = STATO_ACCESA;
                else
                    stato = STATO_SPENTA;
            }
            return stato;
        }
    }
}

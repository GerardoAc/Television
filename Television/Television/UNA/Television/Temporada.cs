using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Television
{
    public class Temporada : Capitulo
    {
        public int FechaProducion
        {
            get;
            set;
        }

        public int FechaEstrenoMundial
        {
            get;
            set;
        }

        public int Duracion
        {
            get;
            set;
        }
    }
}
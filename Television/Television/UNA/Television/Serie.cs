using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Television
{
    public class Serie
    {
        public string Titulo
        {
            get;
            set;
        }

        public int AnoInicio
        {
            get;
            set;
        }

        public string Sinopsis
        {
            get;
            set;
        }

        public string Genero
        {
            get;
            set;
        }

        public Marcar Marcar
        {
            get => default;
            set
            {
            }
        }

        public MarcarFavorito MarcarFavorito
        {
            get => default;
            set
            {
            }
        }
    }
}
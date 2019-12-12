using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Television
{
    public class Usuario : Serie
    {
        public String Nombre
        {
            get;
            set;


        }

        public string Contraseña
        {
            get;
            set;

        }

        public string CorreoElectronico
        {
            get;
            set;
        }

        public int FechaNacimiento
        {
            get;
            set;
        }

        public string Apellido
        {
            get;
            set;
        }

        public Sugerir Sugerir
        {
            get => default;
            set
            {
            }
        }

        public Temporada Temporada
        {
            get => default;
            set
            {
            }
        }

        public Capitulo Capitulo
        {
            get => default;
            set
            {
            }
        }
    }
}
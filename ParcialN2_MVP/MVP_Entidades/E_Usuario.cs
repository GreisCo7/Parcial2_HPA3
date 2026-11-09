using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Entidades
{
    public class E_Usuario
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string PasswordHash { get; set; }
    }
}

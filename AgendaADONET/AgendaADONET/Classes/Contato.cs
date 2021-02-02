using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AgendaADONET.Classes
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
    }
}

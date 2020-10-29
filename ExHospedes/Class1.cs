using System;
using System.Collections.Generic;
using System.Text;

namespace ExHospedes
{
    class Hospedes
    {
        public string Nome { get; set; } //Get e Set dos Nomes dos hóspedes
        public string Email { get; set; } //Get e Set dos Emails dos Hóspedes
        public Hospedes(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}

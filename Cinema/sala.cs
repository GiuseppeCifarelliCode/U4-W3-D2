using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema
{
    public class sala
    {
        public string nome { get; set; }
        public string cognome { get; set; }

        public bool ridotto = false;

        public sala() { }
        public sala(string nome, string cognome, bool ridotto)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.ridotto = ridotto;
        }
    }
}
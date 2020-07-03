using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Country
    {
        public State[] Top10StatesByArea()
        {
            return new State[]
            {
                new State("Amazonas", "AM"),
                new State("Par�", "PA"),
                new State("Mato Grosso", "MT"),
                new State("Minas Gerais", "MG"),
                new State("Bahia", "BA"),
                new State("Mato Grosso do Sul", "MS"),
                new State("Goi�s", "GO"),
                new State("Maranh�o", "MA"),
                new State("Rio Grande do Sul", "RS"),
                new State("Tocantins", "TO"),
            };
        }
    }
}
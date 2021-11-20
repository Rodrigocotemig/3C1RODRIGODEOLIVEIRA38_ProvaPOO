using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1Rodrigo38_ProvaPOO.Code.DTO
{
    class SGDTO
    {
        private int _ID;
        private string _JOGO;
        private double _VALOR;
        private string _PLATAFORMA;

        public int ID { get => _ID; set => _ID = value; }
        public string JOGO { get => _JOGO; set => _JOGO = value; }
        public double VALOR { get => _VALOR; set => _VALOR = value; }
        public string PLATAFORMA { get => _PLATAFORMA; set => _PLATAFORMA = value; }
    }
}

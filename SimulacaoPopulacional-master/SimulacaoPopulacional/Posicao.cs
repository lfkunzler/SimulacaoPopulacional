using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoPopulacional
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public Posicao(int x, int y)
        {
            Linha = x;
            Coluna = y;
        }

        public void DefinePosicao(int x, int y)
        {
            Linha = x;
            Coluna = y;
        }

        public void PosicaoOrigem()
        {
            Linha = Coluna = 0;
        }

        public void Norte()
        {
            Linha--;
        }

        public void Nordeste()
        {
            Linha--;
            Coluna++;
        }

        public void Leste()
        {
            Coluna++;
        }

        public void Sudeste()
        {
            Linha++;
            Coluna++;
        }

        public void Sul()
        {
            Linha++;
        }
        public void Sudoeste()
        {
            Linha++;
            Coluna--;
        }

        public void Oeste()
        {
            Coluna--;
        }

        public void Noroeste()
        {
            Linha--;
            Coluna--;
        }

    }
}


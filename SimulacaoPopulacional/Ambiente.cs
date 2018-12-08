using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacaoPopulacional
{
    class Ambiente
    {
        public List<Sapo> Sapos;
        public List<Mosca> Moscas;
        public List<Acucar> Acucares;

        private int qtdePopSaposInic;
        private int qtdePopMoscasInic;
        private int qtdeAcucarInic;

        public Semaphore s_mutex;
        public Semaphore s_ambiente;

        private int largura;
        private int altura;


        public Ambiente(int qtdePopSaposInic, int qtdePopMoscasInic, int qtdeAcucarInic, int largura, int altura, int calini, int calmax)
        {
            Sapo auxsapo;
            Posicao auxpos;
            Random rnd = new Random();

            Sapos = new List<Sapo>();
            Moscas = new List<Mosca>();
            Acucares = new List<Acucar>();
       
            int i;
            this.largura = largura;
            this.altura = altura;
            this.qtdePopSaposInic = qtdePopSaposInic;
            this.qtdePopMoscasInic = qtdePopMoscasInic;
            this.qtdeAcucarInic = qtdeAcucarInic;
          

            for (i = 0; i < qtdePopSaposInic; i++) {
                auxpos = new Posicao(rnd.Next(0, largura), rnd.Next(0, altura));
                auxsapo = new Sapo(i, auxpos, this, calini);
                Sapos.Add(auxsapo);
            }
          
        }
    }
}

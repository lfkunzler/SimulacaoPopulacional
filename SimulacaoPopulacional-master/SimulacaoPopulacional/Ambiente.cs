using SimulacaoPopulacional.Views;
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
        private const int MOVCIMA = -3;
        private const int MOVBAIXO = 3;
        private const int MOVESQ = -3;
        private const int MOVDIR = 3;
        private const int BORDA = 0;

        public List<Sapo> Sapos;
        public List<Mosca> Moscas;
        public List<Acucar> Acucares;
        public List<Thread> ThreadsSapos;
        public List<Thread> ThreadsMoscas;

        private frmSimulacao formSim;

        private int qtdePopSaposInic;
        private int qtdePopMoscasInic;
        private int qtdeAcucarInic;
        private int qtdeCalIni;
        private int qtdeCalRep;

        public int individuos;

        public Semaphore s_mutex;
        public Semaphore s_ambiente;
        public Semaphore s_barreira;
        public Thread tid_amb;

        public int largura;
        public int altura;

        public Ambiente(int qtdePopSaposInic, int qtdePopMoscasInic, int qtdeAcucarInic, int largura, int altura, int calini, int calrep, frmSimulacao formSim)
        {
            Sapo auxsapo;
            Mosca auxmosca;
            Acucar auxacucar;
            Posicao auxpos;
            Thread auxthread;

            Random rnd = new Random();

            Sapos = new List<Sapo>();
            Moscas = new List<Mosca>();
            Acucares = new List<Acucar>();
            ThreadsSapos = new List<Thread>();
            ThreadsMoscas = new List<Thread>();

            individuos = 0;

            int i;
            this.largura = largura;
            this.altura = altura;
            this.qtdePopSaposInic = qtdePopSaposInic;
            this.qtdePopMoscasInic = qtdePopMoscasInic;
            this.qtdeAcucarInic = qtdeAcucarInic;
            this.qtdeCalIni = calini;
            this.qtdeCalRep = calrep;
            this.formSim = formSim;

            s_ambiente = new Semaphore(0, 1);
            s_mutex = new Semaphore(1, 1);
            s_barreira = new Semaphore(0, 100);

            for (i = 0; i < qtdePopSaposInic; i++)
            {
                auxpos = new Posicao(rnd.Next(0, largura), rnd.Next(0, altura));
                auxsapo = new Sapo(i, auxpos, this, calini, null);
                auxthread = new Thread(auxsapo.Movimenta);
                auxsapo.tid_Sapo = auxthread;
                Sapos.Add(auxsapo);
                ThreadsSapos.Add(auxthread);
            }
            for (i = 0; i < qtdePopMoscasInic; i++)
            {
                auxpos = new Posicao(rnd.Next(0, largura), rnd.Next(0, altura));
                auxmosca = new Mosca(i, auxpos, this, calini, null);
                auxthread = new Thread(auxmosca.Movimenta);
                auxmosca.tid_Mosca = auxthread;
                Moscas.Add(auxmosca);
                ThreadsMoscas.Add(auxthread);
            }
            for (i = 0; i < qtdeAcucarInic; i++)
            {
                auxpos = new Posicao(rnd.Next(0, largura), rnd.Next(0, altura));
                auxacucar = new Acucar(i, auxpos, this);
                Acucares.Add(auxacucar);
            }


            tid_amb = new Thread(th_amb);
            tid_amb.Start();

        }

        private delegate void MataSapoDelegate(Sapo aux);
        private void MataSapo(Sapo aux)
        {

            if (aux.Figura.InvokeRequired)
            {
                MataSapoDelegate d = new MataSapoDelegate(MataSapo);
                aux.Figura.Invoke(d, new object[] { aux });

            }
            else
            {
                aux.tid_Sapo.Abort();
                aux.Figura.Dispose();

                ThreadsSapos.Remove(aux.tid_Sapo);

            }

        }
        private delegate void MataMoscaDelegate(Mosca aux);
        private void MataMosca(Mosca aux)
        {

            if (aux.Figura.InvokeRequired)
            {
                MataMoscaDelegate d = new MataMoscaDelegate(MataMosca);
                aux.Figura.Invoke(d, new object[] { aux });

            }
            else
            {
                aux.tid_Mosca.Abort();
                aux.Figura.Dispose();

                ThreadsMoscas.Remove(aux.tid_Mosca);

            }

        }

        private delegate void MataAcucarDelegate(Acucar aux);
        private void MataAcucar(Acucar aux)
        {

            if (aux.Figura.InvokeRequired)
            {
                MataAcucarDelegate d = new MataAcucarDelegate(MataAcucar);
                aux.Figura.Invoke(d, new object[] { aux });

            }
            else
            {
                aux.Figura.Dispose();
                Acucares.Remove(aux);

            }

        }

        private delegate void ChecaPosicaoSapoDelegate(Sapo sapo);
        private void ChecaPosicaoSapo(Sapo sapo)
        {
            if (sapo.Figura.InvokeRequired)
            {
                ChecaPosicaoSapoDelegate d = new ChecaPosicaoSapoDelegate(ChecaPosicaoSapo);
                sapo.Figura.Invoke(d, new object[] { sapo });
            }
            else
            {
                sapo.pos.Coluna = sapo.Figura.Left;
                sapo.pos.Linha = sapo.Figura.Top;
            }
        }

        private delegate void ChecaPosicaoMoscaDelegate(Mosca mosca);
        private void ChecaPosicaoMosca(Mosca mosca)
        {
            if (mosca.Figura.InvokeRequired)
            {
                ChecaPosicaoMoscaDelegate d = new ChecaPosicaoMoscaDelegate(ChecaPosicaoMosca);
                mosca.Figura.Invoke(d, new object[] { mosca });
            }
            else
            {
                mosca.pos.Coluna = mosca.Figura.Left;
                mosca.pos.Linha = mosca.Figura.Top;
            }
        }

        // recebe a posicao atual do individuo e retorna alteracao no deslocamento necessaria
        Posicao VerificaBorda(Posicao pos, Posicao desl_atual)
        {
            Posicao altera_desl = new Posicao(0, 0);
            // meio do objeto
            pos.Linha += 25;
            pos.Coluna += 25;

            // canto inferior direito
            if (pos.Linha + BORDA > altura && pos.Coluna + BORDA > largura)
            {
                altera_desl.Coluna = MOVESQ;
                altera_desl.Linha = MOVCIMA;
            }
            // canto inferior esquerdo
            else if (pos.Linha + 25 > altura && pos.Coluna - BORDA < 0)
            {
                altera_desl.Coluna = MOVDIR;
                altera_desl.Linha = MOVCIMA;
            }
            // canto superior direito
            else if (pos.Linha - 50 < 0 && pos.Coluna + BORDA > largura)
            {
                altera_desl.Coluna = MOVESQ;
                altera_desl.Linha = MOVBAIXO;
            }
            // canto superior esquerdo
            else if (pos.Linha - 50 < 0 && pos.Coluna - BORDA < 0)
            {
                altera_desl.Coluna = MOVDIR;
                altera_desl.Linha = MOVBAIXO;
            }
            // se esta em cima
            else if (pos.Linha - 50 < 0)
            {
                altera_desl.Linha = MOVBAIXO;
                altera_desl.Coluna = desl_atual.Coluna;
            }
            // se esta em baixo
            else if (pos.Linha + BORDA > altura)
            {
                altera_desl.Linha = MOVCIMA;
                altera_desl.Coluna = desl_atual.Coluna;
            }
            // se esta na esquerda
            else if (pos.Coluna - 25 < 0)
            {
                altera_desl.Linha = desl_atual.Linha;
                altera_desl.Coluna = MOVDIR;
            }
            // se esta na direita
            else if (pos.Coluna + BORDA > largura)
            {
                altera_desl.Linha = desl_atual.Linha;
                altera_desl.Coluna = MOVESQ;
            }
            else
            {
                return desl_atual;
            }

            return altera_desl;
        }

        private delegate void ReproduzMoscaDelegate(Mosca mosca);
        public void ReproduzMosca(Mosca mosca)
        {
            if (formSim.InvokeRequired)
            {
                ReproduzMoscaDelegate d = new ReproduzMoscaDelegate(ReproduzMosca);
                formSim.Invoke(d, new object[] { mosca });
            }
            else
            {
                formSim.Controls.Add(mosca.Figura);

                mosca.tid_Mosca.Start();
            }
        }

        public void th_amb()
        {
            Sapo sapoA;
            Mosca moscaA;

            while (true)
            {
                s_ambiente.WaitOne();

                // sapos
                for (int i = 0; i < Sapos.Count; i++)
                {
                    sapoA = Sapos.ElementAt(i);
                    ChecaPosicaoSapo(sapoA);
                    Posicao aux = sapoA.pos;
                    aux.Coluna += 25;
                    aux.Linha += 25;
                    for (int j = 0; j < Moscas.Count; j++)
                    {
                        ChecaPosicaoMosca(Moscas.ElementAt(j));
                        Posicao aux2 = Moscas.ElementAt(j).pos;
                        aux2.Coluna += 25;
                        aux2.Linha += 25;
                        int x = Math.Abs(aux.Linha - aux2.Linha);
                        int y = Math.Abs(aux.Coluna - aux2.Coluna);

                        if (x < 45 && y < 45)
                        {
                            sapoA.Calorias += Moscas.ElementAt(j).Calorias;
                            MataMosca(Moscas.ElementAt(j));
                            Moscas.RemoveAt(j);
                        }
                    }

                    if (sapoA.Calorias <= 0)
                    {
                        MataSapo(sapoA);
                        Sapos.RemoveAt(i);
                    }
                    ChecaPosicaoSapo(sapoA);
                    sapoA.Desloca = VerificaBorda(sapoA.pos, sapoA.Desloca);
                }

                // moscas
                for (int i = 0; i < Moscas.Count; i++)
                {
                    moscaA = Moscas.ElementAt(i);
                    ChecaPosicaoMosca(moscaA);
                    Posicao aux = moscaA.pos;
                    aux.Coluna += 25;
                    aux.Linha += 25;
                    for (int j = 0; j < Acucares.Count; j++)
                    {
                        Posicao aux2 = Acucares.ElementAt(j).consulta();
                        aux2.Coluna += 25;
                        aux2.Linha += 25;
                        int x = Math.Abs(aux.Linha - aux2.Linha);
                        int y = Math.Abs(aux.Coluna - aux2.Coluna);

                        if (x < 45 && y < 45)
                        {
                            moscaA.Calorias += Acucares.ElementAt(j).cal;
                            if (moscaA.Calorias >= qtdeCalRep)
                            {
                                Random rnd = new Random();
                                Mosca auxmosca = new Mosca(i, new Posicao(rnd.Next(0, largura), rnd.Next(0, altura)), this, qtdeCalRep - 1, null);
                                Thread auxthread = new Thread(auxmosca.Movimenta);
                                auxmosca.tid_Mosca = auxthread;
                                Moscas.Add(auxmosca);
                                ThreadsMoscas.Add(auxthread);
                                ReproduzMosca(auxmosca);
                                moscaA.Calorias = qtdeCalRep - 1;
                            }
                            MataAcucar(Acucares.ElementAt(j));
                        }
                    }

                    if (moscaA.Calorias <= 0)
                    {
                        MataMosca(moscaA);
                        Moscas.RemoveAt(i);
                    }
                    ChecaPosicaoMosca(moscaA);
                    moscaA.Desloca = VerificaBorda(moscaA.pos, moscaA.Desloca);
                }
                s_mutex.WaitOne();
                for (int i = 0; i < Sapos.Count + Moscas.Count; i++)
                {
                    s_barreira.Release();
                }
                individuos = 0;
                s_mutex.Release();
            }
        }
    }
}

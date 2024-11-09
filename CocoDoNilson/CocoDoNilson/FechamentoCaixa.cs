using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using MySql.Data.MySqlClient;

namespace CocoDoNilson
{
    public partial class FechamentoCaixa : Form
    {
        double copo200, copo300, copo400, copo500, totalCopos;
        double garrafa500, garrafa1l, garrafa2l, fidelidade1l, fidelidade2l, cGarrafa1l, cGarrafa2l, totalGarrafas;
        double cocoUnd, oleo150, oleo500, lascas, totalOutros;
        double cocoPreco, cocoTotal, cocoPago, cocoFinal;
        int cocoQtd;
        double embalagem, gelo, marmita, outros, totalGastos;
        double fechamentoVendas, fechamentoGastos, fechamentoLucro, fechamentoDizimo;

        public FechamentoCaixa()
        {
            InitializeComponent();
        }

        private void FechamentoCaixa_Load(object sender, EventArgs e)
        {
            //ConexaoMySql mysql = new ConexaoMySql();
            //mysql.GetFechamentosExistentes();

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            ValoresProdutos valores = new ValoresProdutos();

            copo200 = Convert.ToDouble(nud200ml.Value) * valores.Copo200;
            copo300 = Convert.ToDouble(nud300ml.Value) * valores.Copo300;
            copo400 = Convert.ToDouble(nud400ml.Value) * valores.Copo400;
            copo500 = Convert.ToDouble(nud500ml.Value) * valores.Copo500;

            totalCopos = copo200 + copo300 + copo400 + copo500;

            tb200ml.Text = copo200.ToString("C");
            tb300ml.Text = copo300.ToString("C");
            tb400ml.Text = copo400.ToString("C");
            tb500ml.Text = copo500.ToString("C");
            tbTotalCopos.Text = totalCopos.ToString("C");

        }

        private void btCalcularGarrafa_Click(object sender, EventArgs e)
        {
            ValoresProdutos valores = new ValoresProdutos();

            garrafa500 = Convert.ToDouble(nudG500ml.Value) * valores.Garrafa500;
            garrafa1l = Convert.ToDouble(nudG1l.Value) * valores.Garrafa1l;
            garrafa2l = Convert.ToDouble(nudG2l.Value) * valores.Garrafa2l;
            cGarrafa1l = Convert.ToDouble(nudG1lCGarrafa.Value) * valores.CGarrafa1l;
            cGarrafa2l = Convert.ToDouble(nudG2lCGarrafa.Value) * valores.CGarrafa2l;
            fidelidade1l = Convert.ToDouble(nudFid1l.Value) * valores.Fidelidade1l;
            fidelidade2l = Convert.ToDouble(nudFid2l.Value) * valores.Fidelidade2l;

            totalGarrafas = garrafa500 + garrafa1l + garrafa2l + cGarrafa1l + cGarrafa2l + fidelidade1l + fidelidade2l;


            tbG500ml.Text = garrafa500.ToString("C");
            tbG1l.Text = garrafa1l.ToString("C");
            tbG2l.Text = garrafa2l.ToString("C");
            tbG1lcG.Text = cGarrafa1l.ToString("C");
            tbG2lcG.Text = cGarrafa2l.ToString("C");
            tbG1lFid.Text = fidelidade1l.ToString("C");
            tbG2lFid.Text = fidelidade2l.ToString("C");


            tbTotalGarrafas.Text = totalGarrafas.ToString("C");
        }

        private void btCalcularOutros_Click(object sender, EventArgs e)
        {
            ValoresProdutos valores = new ValoresProdutos();

            cocoUnd = Convert.ToDouble(nudCocoUnd.Value) * valores.CocoUnd;
            oleo150 = Convert.ToDouble(nudOleo150.Value) * valores.Oleo150;
            oleo500 = Convert.ToDouble(nudOleo500.Value) * valores.Oleo500;
            lascas = Convert.ToDouble(nudLascas.Value) * valores.Lascas;

            totalOutros = cocoUnd + oleo150 + oleo500 + lascas;

            tbCocoUnd.Text = cocoUnd.ToString("C");
            tbOleo150.Text = oleo150.ToString("C");
            tbOleo500.Text = oleo500.ToString("C");
            tbLascas.Text = lascas.ToString("C");
            tbTotalOutros.Text = totalOutros.ToString("C");

        }

        private void nudCocoQtd_ValueChanged(object sender, EventArgs e)
        {
            cocoPreco = Convert.ToDouble(nudCocoPreco.Value);
            cocoQtd = Convert.ToInt32(nudCocoQtd.Value);

            cocoTotal = cocoPreco * cocoQtd;

            tbTotalCoco.Text = cocoTotal.ToString("C");
        }

        private void nudCocoPago_ValueChanged(object sender, EventArgs e)
        {
        //    cocoPago = Convert.ToDouble(nudCocoPago.Value);
        //    cocoFinal = cocoTotal - cocoPago;

        //    tbFinalCoco.Text = cocoFinal.ToString("C");
        }

        private void btTotalGastos_Click(object sender, EventArgs e)
        {

            embalagem = Convert.ToDouble(nudEmbalagem.Value);
            gelo = Convert.ToDouble(nudGelo.Value);
            marmita = Convert.ToDouble(nudMarmita.Value);
            outros = Convert.ToDouble(nudOutros.Value);

            totalGastos = embalagem + gelo + marmita + outros + cocoTotal;


            tbTotalGastos.Text = totalGastos.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fechamentoVendas = totalCopos + totalGarrafas + totalOutros;
            fechamentoGastos = totalGastos;
            fechamentoLucro = fechamentoVendas - fechamentoGastos;
            fechamentoDizimo = fechamentoLucro * 0.10;

            tbFechamentoVendas.Text = fechamentoVendas.ToString("C");
            tbFechamentoGastos.Text = fechamentoGastos.ToString("C");
            tbFechamentoLucro.Text  = fechamentoLucro.ToString("C");
            tbFechamentoDizimo.Text = fechamentoDizimo.ToString("C");   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml.Permissions;

namespace CocoDoNilson
{
    public class ValoresProdutos
    {
        double copo200 = 3.0, copo300 = 4.0, copo400 = 5.0, copo500 = 6.50;
        double garrafa500 = 7.50, garrafa1l = 13.0, garrafa2l = 25.0;
        double cGarrafa1l = 12.0, cGarrafa2l = 24.0;
        double fidelidade1l = -13.0, fidelidade2l = -25.0;
        double lascas = 14.0,oleo150 = 15.0,oleo500 = 35.0, cocoUnd = 7.0, gelo,embalagens,cocoMaterial;

            
        public ValoresProdutos()
        {

        }
            
        public double Copo200 => copo200;

        public double Copo300 => copo300;

        public  double Copo400 => copo400;

        public double Copo500 => copo500;

        public double Garrafa500 => garrafa500;

        public double Garrafa1l => garrafa1l;

        public double Garrafa2l => garrafa2l;

        public double Fidelidade1l => fidelidade1l;

        public double Fidelidade2l => fidelidade2l;

        public double CGarrafa1l => cGarrafa1l;

        public double CGarrafa2l => cGarrafa2l;

        public double Lascas { get => lascas; set => lascas = value; }
        public double Oleo150 { get => oleo150; set => oleo150 = value; }
        public double Oleo500 { get => oleo500; set => oleo500 = value; }
        public double CocoUnd { get => cocoUnd; set => CocoUnd = value; }
        public double Gelo { get => gelo; set => gelo = value; }
        public double Embalagens { get => embalagens; set => embalagens = value; }
        public double CocoMaterial { get => cocoMaterial; set => cocoMaterial = value; }
    }
}

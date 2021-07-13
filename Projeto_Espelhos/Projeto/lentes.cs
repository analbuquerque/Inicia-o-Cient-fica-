using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class lentes
    {
        public double lenses(int f, int p)
        {
            double plinha;
            plinha = (p * f) / (p - f);

            return plinha;
        }

        public double lens(double objeto, double focus, double plin)
        {
            double ppp;
            double img;
            ppp = (plin * focus) / (plin - focus);
            img = (-ppp / plin) * objeto;
            return img;
        }

        public double ampliacao(double obj, double foc, double pp)
        {
            double plin;
            double img;
            double a;
            plin = (pp * foc) / (pp - foc);
            img = (-plin / pp) * obj;
            a = (img / obj);
            return a;
        }


    }
}


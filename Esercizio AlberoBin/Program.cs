using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_AlberoBin
{
    class Program
    {
        class Nodo
        {
            int val;
            Nodo succDx;
            Nodo succSx;

            public Nodo(int val)
            {
                this.val = val;
            }

            public void setSuccDx(Nodo n) 
            {
                this.succDx = n;
            }

            public void setSuccSx(Nodo n) 
            {
                this.succSx = n;
            }

            public int getVal()
            {
                return val;
            }

            public void setVal(int val)
            {
                this.val = val;
            }
        }

        class AlberoBinario
        {
            Nodo radice;
            AlberoBinario dx;
            AlberoBinario sx;

            public AlberoBinario(Nodo n)
            {
                radice = n;
            }
            public AlberoBinario() { }

            public void insDX(int val)
            {
                Nodo n = new Nodo(val);
                if (radice == null)
                {
                    radice = n;
                }
                else
                {
                    n.setSuccDx(radice);
                    radice = n;
                }
            }
            public void insSX(int val)
            {
                Nodo n = new Nodo(val);
                if (radice == null)
                {
                    radice = n;
                }
                else
                {
                    n.setSuccSx(radice);
                    radice = n;
                }
            }
        }


        static void Main(string[] args)
        {
            AlberoBinario a = new AlberoBinario();
            a.insDX(69);
            a.insDX(23);
            a.insSX(33);
        }

    }
}

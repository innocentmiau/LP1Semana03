using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string a = "2,2";
            int d = 2;
            int[] e = new int[d];
            for (int i = 0; i < d; i++)
            {
                e[i] = i;
            }
            float[] f = new float[6];
            for(int i = 0; i<args.Length; i++)
            {
                f[i] = float.Parse(args[i]);
            }

            int g = int.Parse(a.Split(",")[0]);
            int h = int.Parse(a.Split(",")[1]);
            float[,] A = new float[g, h];
            float[] b = new float[d];
            for (int i = 0; i < (g * h); i++)
            {
                string j = Convert.ToString(i, 2);
                if (j.Length < 2) j = "0" + j;
                A[int.Parse(j[0].ToString()), int.Parse(j[1].ToString())] = f[i];
            }

            foreach (int i in e)
            {
                int k = 0;
                foreach (int ii in e)
                {
                    if (ii == i) break;
                    k += 1;
                }
                b[k] = f[4 + k];
            }

            M m = new M();
            string[] r = new string[d];
            for (int l = 0; l < g; l++)
            {
                float total = 0;
                for (int ll = 0; ll < h; ll++)
                {
                    total += (A[l, ll] * b[ll]);
                }
                r[l] = $"{m.n(O.ongod)} {total,7:F2} {m.n(O.ongod)}";
            }

            Z z = new Z();
            foreach (string s in r)
            {
                foreach (char c in s)
                {
                    z.w(c.ToString());
                }
                z.w(m.n(O.baobao));
            }
            
        }
        
    }

    public class Z
    {
        public void w(string w_) => Console.Write(w_);
    }
    
    public class M
    {
        public string n(O o_)
        {
            switch (o_)
            {
                case O.baobao:
                    return "\n";
                case O.ongod:
                    return "|";
                default:
                    return null;
            }
        }
    }
    

    public enum O
    {
        baobao, ongod
    }
}

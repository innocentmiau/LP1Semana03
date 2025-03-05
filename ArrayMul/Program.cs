using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string sizeMatrix = "2,2";
            int sizeVector = 2;
            int[] vector = new int[sizeVector];
            for (int i = 0; i < sizeVector; i++)
            {
                vector[i] = i;
            }
            float[] floats = new float[6];
            for(int i = 0; i<args.Length; i++)
            {
                floats[i] = float.Parse(args[i]);
            }

            int eachLine = int.Parse(sizeMatrix.Split(",")[0]);
            int sizeLine = int.Parse(sizeMatrix.Split(",")[1]);
            float[,] A = new float[eachLine, sizeLine];
            float[] b = new float[sizeVector];
            for (int i = 0; i < (eachLine * sizeLine); i++)
            {
                string bye = Convert.ToString(i, 2);
                if (bye.Length < 2) bye = "0" + bye;
                A[int.Parse(bye[0].ToString()), int.Parse(bye[1].ToString())] = floats[i];
            }

            foreach (int i in vector)
            {
                int index = 0;
                foreach (int ii in vector)
                {
                    if (ii == i) break;
                    index += 1;
                }
                b[index] = floats[4 + index];
            }

            for (int l = 0; l < eachLine; l++)
            {
                float total = 0;
                for (int ll = 0; ll < sizeLine; ll++)
                {
                    total += (A[l, ll] * b[ll]);
                }
                Console.WriteLine($"| {total,7:F2} |");
            }
            
        }
    }
}

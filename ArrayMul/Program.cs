﻿using System;namespace ArrayMul{public class Program{private static void Main(string[]a){string b="2,2";int c=2,d=int.Parse(b.Split(',')[0]),e=int.Parse(b.Split(',')[1]);int[]f=new int[c];for(int g=0;g<c;g++)f[g]=g;float[]h=new float[6];for(int g=0;g<a.Length;g++)h[g]=float.Parse(a[g]);float[,]B=new float[d,e];float[]i=new float[c];for(int g=0;g<d*e;g++){string j=Convert.ToString(g,2).PadLeft(2,'0');B[int.Parse(j[0].ToString()),int.Parse(j[1].ToString())]=h[g];}foreach(int g in f){int k=0;foreach(int l in f){if(l==g)break;k++;}i[k]=h[4+k];}M m=new M();Z r=new Z();for(int o=0;o<d;o++){float p=0;for(int q=0;q<e;q++)p+=B[o,q]*i[q];string s=$"{m.n(O.ongod)} {p,7:F2} {m.n(O.ongod)}";foreach(char t in s)r.w(t.ToString());r.w(m.n(O.baobao));}}}public class Z{public void w(string a)=>Console.Write(a);}public class M{public string n(O a)=>a==O.baobao?"\n":"|";}public enum O{baobao,ongod}}
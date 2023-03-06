using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Numerics;
using Mathd;
using UnityEngine.Internal;

public class WF
    {
        public static long Factorial(int n)//階乗計算
        {
            if (n == 0)
                return 1L;
            return n * Factorial(n - 1);
        }

        public List<int> GetArithmeticProgression(int start, int difference, int maxGenerateNumber)//等差数列作成
        {
            var list = new List<int>();
            for (int n = 1; n <= maxGenerateNumber; n++)
                list.Add(start + (n - 1) * difference);
            return list;
        }

        public static double Legendre(int l, int m, double x)//ルジャンドル陪多項式
        {
        double qw = Math.Pow((1 - Math.Pow(x, 2)), m / 2f);

        if (l == 0) return qw;
        else if (l == 1 && m == 0) return x * qw;
        else if (l == 1 && m == 1) return qw;
        else if (l == 2 && m == 0) return (3 * Math.Pow(x, 2) - 1) / 2 * qw;
        else if (l == 2 && m == 1) return (6 * x) / 2 * qw;
        else if (l == 2 && m == 2) return 6 / 2 * qw;
        else if (l == 3 && m == 0) return (5 * Math.Pow(x, 3) - 3 * x) / 2 * qw;
        else if (l == 3 && m == 1) return (15 * Math.Pow(x, 2) - 3) / 2 * qw;
        else if (l == 3 && m == 2) return 30 * x / 2 * qw;
        else if (l == 3 && m == 3) return 30 / 2 * qw;
        else if (l == 4 && m == 0) return (35 * Math.Pow(x, 4) - 30 * Math.Pow(x, 2) + 3) / 8 * qw;
        else if (l == 4 && m == 1) return (140 * Math.Pow(x, 3) - 60 * x) / 8 * qw;
        else if (l == 4 && m == 2) return (420 * Math.Pow(x, 2) - 60) / 8 * qw;
        else if (l == 4 && m == 3) return 840 * x / 8 * qw;
        else if (l == 4 && m == 4) return 840 / 8 * qw;
        else if (l == 5 && m == 0) return (63 * Math.Pow(x, 5) - 70 * Math.Pow(x, 3) + 15 * x) / 8 * qw;
        else if (l == 5 && m == 1) return (315 * Math.Pow(x, 4) - 210 * Math.Pow(x, 2) + 15) / 8 * qw;
        else if (l == 5 && m == 2) return (1260 * Math.Pow(x, 3) - 420 * x) / 8 * qw;
        else if (l == 5 && m == 3) return (3780 * Math.Pow(x, 2) - 420) / 8 * qw;
        else if (l == 5 && m == 4) return (7560 * x / 8) * qw;
        else if (l == 5 && m == 5) return 7560 / 8 * qw;
        else if (l == 6 && m == 0) return (231 * Math.Pow(x, 6) - 315 * Math.Pow(x, 4) + 105 * Math.Pow(x, 2) - 5) / 16 * qw;
        else if (l == 6 && m == 1) return (1386 * Math.Pow(x, 5) - 1260 * Math.Pow(x, 3) + 210 * x) / 16 * qw;
        else if (l == 6 && m == 2) return (6930 * Math.Pow(x, 4) - 3780 * Math.Pow(x, 2) + 210) / 16 * qw;
        else if (l == 6 && m == 3) return (27720 * Math.Pow(x, 3) - 7560 * x) / 16 * qw;
        else if (l == 6 && m == 4) return (83160 * Math.Pow(x, 2) - 7560) / 16 * qw;
        else if (l == 6 && m == 5) return (166320 * x) / 16 * qw;
        else if (l == 6 && m == 6) return 166320 / 16 * qw;
        else if (l == 7 && m == 0) return (429 * Math.Pow(x, 7) - 693 * Math.Pow(x, 5) + 315 * Math.Pow(x, 3) - 35 * x) / 16 * qw;
        else if (l == 7 && m == 1) return (3003 * Math.Pow(x, 6) - 3465 * Math.Pow(x, 4) + 945 * Math.Pow(x, 2) - 35) / 16 * qw;
        else if (l == 7 && m == 2) return (18018 * Math.Pow(x, 5) - 13860 * Math.Pow(x, 3) + 1890 * x) / 16 * qw;
        else if (l == 7 && m == 3) return (90090 * Math.Pow(x, 4) - 41580 * Math.Pow(x, 2) + 1890) / 16 * qw;
        else if (l == 7 && m == 4) return (360360 * Math.Pow(x, 3) - 83160 * x) / 16 * qw;
        else if (l == 7 && m == 5) return (1081080 * Math.Pow(x, 2) - 83160) / 16 * qw;
        else if (l == 7 && m == 6) return (2162160 * x) / 16 * qw;
        else if (l == 7 && m == 7) return 2162160 / 16 * qw;
        else if (l == 8 && m == 0) return (6435 * Math.Pow(x, 8) - 12012 * Math.Pow(x, 6) + 6930 * Math.Pow(x, 4) - 1260 * Math.Pow(x, 2) + 35) / 128 * qw;
        else if (l == 8 && m == 1) return (51480 * Math.Pow(x, 7) - 72072 * Math.Pow(x, 5) + 27720 * Math.Pow(x, 3) - 2520 * x) / 128 * qw;
        else if (l == 8 && m == 2) return (360360 * Math.Pow(x, 6) - 360360 * Math.Pow(x, 4) + 83160 * Math.Pow(x, 2) - 2520) / 128 * qw;
        else if (l == 8 && m == 3) return (2162160 * Math.Pow(x, 5) - 1441440 * Math.Pow(x, 3) + 166320 * x) / 128 * qw;
        else if (l == 8 && m == 4) return (10810800 * Math.Pow(x, 4) - 4324320 * Math.Pow(x, 2) + 166320) / 128 * qw;
        else if (l == 8 && m == 5) return (43243200 * Math.Pow(x, 3) - 8648640 * x) / 128 * qw;
        else if (l == 8 && m == 6) return (129729600 * Math.Pow(x, 2) - 8648640) / 128 * qw;
        else if (l == 8 && m == 7) return (259459200 * x) / 128 * qw;
        else if (l == 8 && m == 8) return 259459200 / 128 * qw;
        else if (l == 9 && m == 0) return (12155 * Math.Pow(x, 9) - 25740 * Math.Pow(x, 7) + 18018 * Math.Pow(x, 5) - 4620 * Math.Pow(x, 3) + 315 * x) / 128 * qw;
        else if (l == 9 && m == 1) return (109395 * Math.Pow(x, 8) - 180180 * Math.Pow(x, 6) + 90090 * Math.Pow(x, 4) - 13860 * Math.Pow(x, 2) + 315) / 128 * qw;
        else if (l == 9 && m == 2) return (875160 * Math.Pow(x, 7) - 1081080 * Math.Pow(x, 5) + 360360 * Math.Pow(x, 3) - 27720 * x) / 128 * qw;
        else if (l == 9 && m == 3) return (6126120 * Math.Pow(x, 6) - 5405400 * Math.Pow(x, 4) + 1081080 * Math.Pow(x, 2) - 27720) / 128 * qw;
        else if (l == 9 && m == 4) return (36756720 * Math.Pow(x, 5) - 21621600 * Math.Pow(x, 3) + 2162160 * x) / 128 * qw;
        else if (l == 9 && m == 5) return (183783600 * Math.Pow(x, 4) - 64864800 * Math.Pow(x, 2) + 2162160) / 128 * qw;
        else if (l == 9 && m == 6) return (735134400 * Math.Pow(x, 3) - 129729600 * x) / 128 * qw;
        else if (l == 9 && m == 7) return (2205403200 * Math.Pow(x, 2) - 129729600) / 128 * qw;
        else if (l == 9 && m == 8) return (4410806400 * x) / 128 * qw;
        else if (l == 9 && m == 9) return 4410806400 / 128 * qw;
        else if (l == 10 && m == 0) return (46189 * Math.Pow(x, 10) - 109395 * Math.Pow(x, 8) + 90090 * Math.Pow(x, 6) - 30030 * Math.Pow(x, 4) + 3465 * Math.Pow(x, 2) - 63) / 256 * qw;
        else if (l == 10 && m == 1) return (12155 * Math.Pow(x, 9) - 875160 * Math.Pow(x, 7) + 540540 * Math.Pow(x, 5) - 120120 * Math.Pow(x, 3) + 6930 * x) / 256 * qw;
        else if (l == 10 && m == 2) return (109395 * Math.Pow(x, 8) - 6126120 * Math.Pow(x, 6) + 2702700 * Math.Pow(x, 4) - 360360 * Math.Pow(x, 2) + 6930) / 256 * qw;
        else if (l == 10 && m == 3) return (875160 * Math.Pow(x, 7) - 36756720 * Math.Pow(x, 5) + 10810800 * Math.Pow(x, 3) - 720720 * x) / 256 * qw;
        else if (l == 10 && m == 4) return (6126120 * Math.Pow(x, 6) - 183783600 * Math.Pow(x, 4) + 32432400 * Math.Pow(x, 2) - 720720) / 256 * qw;
        else if (l == 10 && m == 5) return (36756720 * Math.Pow(x, 5) - 735134400 * Math.Pow(x, 3) + 64864800 * x) / 256 * qw;
        else if (l == 10 && m == 6) return (183783600 * Math.Pow(x, 4) - 2205403200 * Math.Pow(x, 2) + 64864800) / 256 * qw;
        else if (l == 10 && m == 7) return (735134400 * Math.Pow(x, 3) - 4410806400 * x) / 256 * qw;
        else if (l == 10 && m == 8) return (2205403200 * Math.Pow(x, 2) - 4410806400) / 256 * qw;
        else if (l == 10 && m == 9) return (4410806400 * x) / 256 * qw;
        else if (l == 10 && m == 10) return 4410806400 / 256 * qw;
        else return 999;
        }

        public static double Ylm(double theta, double phi, int l, int m)//球面調和関数1
        {
            int ab = 2 * l + 1;
            double cd = Factorial(l - Math.Abs(m));
            double ef = 4 * Math.PI * Factorial(l + Math.Abs(m));
            double gh = Math.Pow(-1, m);
            if (m < 0)
            {
                return gh * Math.Sqrt(2 * ab * cd / ef) * Legendre(l, Math.Abs(m), Math.Cos(theta)) * Math.Sin(Math.Abs(m) * phi);
            }
            else if (m == 0)
            {
                return Math.Sqrt(ab / (4 * Math.PI)) * Legendre(l, m, Math.Cos(theta));
            }
            else //(m>0)
            {
                //Debug.Log("Ylm ="+ (Math.Pow(-1, m) * Math.Sqrt(2 * (2 * l + 1) * Factorial(l - m) / (4 * Math.PI * Factorial(l + m)))) * Legendre(m, l, Math.Cos(theta)) * Math.Sin(m * phi));
                return gh * Math.Sqrt(2 * ab * cd / ef) * Legendre(l, m, Math.Cos(theta)) * Math.Cos(m * phi);
            }
        }

        public static Complex Yml(double theta, double phi, int l, int m)//球面調和関数2
        {
            if (m < 0)
            {
                var c = new Complex(Ylm(theta, phi, l, Math.Abs(m)), -Ylm(theta, phi, l, -Math.Abs(m)));
                //Debug.Log("Yml =" + (1 / Math.Sqrt(2) * c));
                return (c / Math.Sqrt(2));
            }
            else if (m == 0)
            {
                //Debug.Log("Yml =" + Ylm(theta,phi,l,m));
                return Ylm(theta, phi, l, m);
            }
            else //( m > 0 )
            {
                var b = new Complex(Ylm(theta, phi, l, Math.Abs(m)), Ylm(theta, phi, l, -Math.Abs(m)));
                //Debug.Log("Yml =" + (Math.Pow(-1, m) / Math.Sqrt(2) * b));
                return (Math.Pow(-1, m) / Math.Sqrt(2) * b);
            }
        }

        public static Complex Sh(double theta, double phi, int l, int m)//球面調和関数実部変換計算
        {
            if (m < 0)
            {
                var a = new Complex(0, 1);
                //Debug.Log("Sh(m<0) =" + a / Math.Sqrt(2) * (Yml(theta, phi, l, m) - Math.Pow(-1, m) * Yml(theta, phi, l, -m)));
                return a / Math.Sqrt(2) * (Yml(theta, phi, l, m) - Math.Pow(-1, m) * Yml(theta, phi, l, -m));
            }
            else if (m == 0)
            {
                //Debug.Log("Sh(m=0) =" + Yml(theta,phi,l,m));
                return Yml(theta, phi, l, m);
            }
            else
            {
                //Debug.Log("Sh(m>0) =" + 1 / Math.Sqrt(2) * (Yml(theta, phi, l, -m) + Math.Pow(-1, m) * Yml(theta, phi, l, m)));
                return 1 / Math.Sqrt(2) * (Yml(theta, phi, l, -m) + Math.Pow(-1, m) * Yml(theta, phi, l, m));
            }
        }

        public static double Get_Real(double theta, double phi, int l, int m)//球面調和関数の実部取得
        {
        //Debug.Log("Get_Real =" + Sh(0.3,0.4,3,1).Real);
        return Sh(theta, phi, l, m).Real;
        }
    }

public class Manager : MonoBehaviour
{
    //public int n = 3;
    public int l = 2;
    public int m = 0;
    public int Z = 1;
    public int size = 100;
    public int yy = 2;
    public int xx = 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        //Debug.Log("Rwf2 = " + WF.Rwf2(1, 1, 1, 1));
        GameObject sphere_prefab = Resources.Load<GameObject>("RedSphere");

        double u = 0, w = 0;
        double[,] F = new double[yy, xx];
        double[,] X = new double[yy, xx];
        double[,] Y = new double[yy, xx];
        double[,] Z = new double[yy, xx];
        //double[,] R = new double[yy, xx];

        //THETAとPHIに使うpiの等差数列作成
        double[] THETA = new double[xx];//piの等差数列(39)
        for (int x = 0; x < xx; x++)//THETA[0]～THETA[39]
        {
            THETA[x] += u;
            //Debug.Log("x ="+ x + " THETA =" + THETA[x]);
            u += Math.PI / (xx);
        }

        double[] PHI = new double[yy];//2piの等差数列(79)
        for (int y = 0; y < yy; y++)
        {
            PHI[y] += w;
            //Debug.Log("y =" + y + " PHI =" + PHI[y]);
            w += 2 * Math.PI / (yy);
        }

        Debug.Log("l = " + l + ", m = " + m);
        int tt = 0;
        for (int y = 0; y < yy; y++)
        {
            for (int x = 0; x < xx; x++)
            {
                F[y, x] = Math.Pow(WF.Get_Real(THETA[x], PHI[y], l, m), 2);
                X[y, x] = size * F[y, x] * Math.Sin(THETA[x]) * Math.Cos(PHI[y]);
                Y[y, x] = size * F[y, x] * Math.Sin(THETA[x]) * Math.Sin(PHI[y]);
                Z[y, x] = size * F[y, x] * Math.Cos(THETA[x]);
                Debug.Log("X[" + y + "," + x + "] =" + X[y, x] + " Y =" + Y[y, x] + " Z =" + Z[y, x]);

                GameObject sphere = Instantiate(sphere_prefab);
                sphere.transform.position = new Mathd.Vector3d(X[y, x], Y[y, x], Z[y, x]);
                sphere.name = "sphere" + tt.ToString();
                //色付けのルール
                if (tt % xx < (xx/2) && tt < (xx*yy)/2)
                {
                    sphere.GetComponent<Renderer>().material.color = Color.red;
                    Debug.Log("Red" + tt);
                }
                else if (tt % xx >= xx/2 && tt < xx*yy/2)
                {
                    sphere.GetComponent<Renderer>().material.color = Color.yellow;
                    Debug.Log("Yellow" + tt);
                }
                else if (tt % xx < xx/2 && tt >= xx*yy/2)
                {
                    sphere.GetComponent<Renderer>().material.color = Color.green;
                    Debug.Log("Green" + tt);
                }
                else
                {
                    sphere.GetComponent<Renderer>().material.color = Color.blue;
                    Debug.Log("Blue" + tt);
                }
                tt++;
            }
        }
    }
    /*
    public void Resize(int m, int l)
    {
        //サイズ、オブジェクト数調節
        if (m == 0 && l < 5)
        {
            size = Math.Pow(2, 1);
            yy = 40;
            xx = 160;
        }        
        else if(m == 0 && l > 4 && l < 8)
        {
            size = Math.Pow(2, 1);
            yy = 40;
            xx = 320;
        }
        else if(m == 0 && l > 7)
        {
            size = Math.Pow(2, 1);
            yy = 40;
            xx = 640;
        }
        else if (m == 1 && l == 10)
        {
            size = 0.001;
            yy = 80;
            xx = 80;
        }
        else if (m == 2 && l == 10)
        {
            size = 0.004;
            yy = 80;
            xx = 80;
        }
        else if(m == 3 && l == 10)
        {
            size = 0.02;
            yy = 160;
            xx = 160;
        }
        else if(m == 4 && l == 10)
        {
            size = 0.05;
            yy = 160;
            xx = 160;
        }
        else if(m == 5 && l == 10)
        {
            size = 0.3;
            yy = 320;
            xx = 320;
        }
        else if(m == 6 && l == 10)
        {
            size = 0.6;
            yy = 320;
            xx = 320;
        }
        else if(m == 7 && l == 10)
        {
            size = 2;
            yy = 320;
            xx = 320;
        }
        else if(m == 8 && l == 10)
        {
            size = 4;
            yy = 320;
            xx = 320;
        }
        else if(m == 9 && l == 10)
        {
            size = 10000;
            yy = 320;
            xx = 320;
        }
        else if(m == 10 && l == 10)
        {
            size = 10000;
            yy = 320;
            xx = 320;
        }
        else
        {
            size = 4;
            yy = 40;
            xx = 40;
        }
    }
    */
    
    // Update is called once per frame
    void Update()
    {

    }
}

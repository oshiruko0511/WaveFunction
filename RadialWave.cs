using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Numerics;
using Mathd;
using UnityEngine.Internal;
using System.Linq;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]

public class NWF
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

    public static double Rwf1(double r, int n, int l, int m, double Z)//動径波動関数1
    {
        //double e = 1.60217663; //* Math.Pow(10, -19);//電気素量e
        //double h = 6.62607015; //* Math.Pow(10, -34);//プランク定数h
        double a = 1; //(Math.Pow(h, 2)) / (4 * Math.Pow(Math.PI, 2) * m * Math.Pow(e, 2));// * Math.Pow(10, -30);
        double rho = 2 * r / ( n * a);
        double rrr = -Math.Pow(Math.Pow((2 / (n * a)), 3) * Factorial(n - l - 1) / (2 * n * Math.Pow(Factorial(n + l), 3)), 0.5);
        double rwf1 = rrr * Math.Exp(- rho / 2) * Math.Pow(rho, l);
        return rwf1;
    }

    public static double Laguerre(int l, int n, double x)//ラゲールの陪多項式
    {
        double Lag = 0;
        for (int k = 0; k <= n - l - 1; k++)
        {
            Lag += (Math.Pow(-1, k+1) * Math.Pow(Factorial(n + l),2) * Math.Pow(x, k)) / (Factorial(k) * Factorial(2 * l + k + 1) * Factorial(n - k - 1 - l));
        }
        /*
        {
            Lag += (Math.Pow(-1, k) * Factorial(n + l) * Math.Pow(x, k)) / (Factorial(k) * Factorial(k + l) * Factorial(n - k));
        }*/
        //Debug.Log("Laguerre =" + Lag);
        return Lag;
    }

    public static double Rwf2(double r, int n, int l, int m, double Z)//動径波動関数2
    {
        //double e = 1.60217663; //* Math.Pow(10, -19);//電気素量e
        //double h = 6.62607015; //* Math.Pow(10, -34);//プランク定数h
        double a = 1;   // (Math.Pow(h, 2)) / (4 * Math.Pow(Math.PI, 2) * m * Math.Pow(e, 2)) * Math.Pow(10, -30);
        double rho = 2 * r / (n * a);
        //Debug.Log("Rwf1 =" + Rwf1(r, n, l, Z) + "Laguerre =" + Laguerre(2 * l + 1, n + l, rho));
        return Rwf1(r, n, l, m, Z) * Laguerre(l , n , rho);
        //return Rwf1(r, n, l, m, Z) * Laguerre(2 * l + 1, n + l , rho);
    }

    public static double Wf(double x, double y, double z, int n, int l, int m, int ZZ)//波動関数
    {
        double r = Euler_Angle_R(x, y, z);
        double theta = Euler_Angle_THETA(x, y, z);
        double phi = Euler_Angle_PHI(x, y, z);
        //Debug.Log("x =" + x + ", y =" + y + ", z =" + z);
        //Debug.Log("r =" + r + ", theta =" + theta + ", phi =" + phi);
        return Get_Real(theta, phi, l, m) * Rwf2(r, n, l, m, ZZ);
    }

    public static double Euler_Angle_R(double x,double y,double z)
    {
        double r = 0;
        r = Math.Sqrt(x * x + y * y + z * z);
        return r;
    }

    public static double Euler_Angle_THETA(double x, double y, double z)
    {
        double theta = 0;
        double r = Euler_Angle_R(x, y, z);
        if (r > 0)
        {
            theta = Math.Acos(z / r);
        }
        return theta;
    }

    public static double Euler_Angle_PHI(double x, double y, double z)
    {
        double phi = 0;
        if (y == 0)
        {
            if (x < 0)
            {
                phi = Math.PI;
            }
        }
        else if (x * x + y * y > 0)
        {
            //phi = Math.Atan(y / x);
            phi = Math.Sign(y) * Math.Acos(x / Math.Sqrt(x * x + y * y));
        }
        return phi;
    }
}

public class RadialWave : MonoBehaviour
{
    public int n = 3;
    public int l = 2;
    public int m = 1;
    public int ZZ = 1;
    public double input_value = 1E-04;
    public int N = 40;                    // サンプリング数（x,y,zをそれぞれ N 等分する）
    public int x_range = 40;              // 計算したい全体領域の範囲 (-x_range <= x,y,z <= x_range)
   

    private Mesh _mesh;
    private MeshFilter _meshFilter;
    // Start is called before the first frame update

    void Start()
    {
        
        _mesh = GetComponent<Mesh>();
        _meshFilter = GetComponent<MeshFilter>();

        CreateWF();
    }

    void CreateWF()
    {
        GameObject sphere_prefab = Resources.Load<GameObject>("RedSphere");

        List<UnityEngine.Vector3> vertices = new List<UnityEngine.Vector3>();
        List<int> triangles = new List<int>();

        Mesh mesh = new Mesh(); // メッシュを作成
        mesh.Clear();

        double delta = 2.0 * x_range / N;   // サンプリング間隔
        //Debug.Log("delta =" + delta);
        int cp = 2 * x_range / N;
        double x = 0;
        double y = 0;
        double z = 0;
        int e = 0;
        var hado = new double[N * N * N][];
        var kakuno = new double[N * N * N][];
        var saigai = new double[N * N * N][];
        int tt = 0;

        Debug.Log("Start");
        Debug.Log("n =" + n + ", l =" + l + ", m =" + m);
        Debug.Log("N =" + N + ", x_range =" + x_range + ", cp =" + cp);
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                for (int k = 0; k < N; k++)
                {
                    x = i * delta - x_range;
                    y = j * delta - x_range;
                    z = k * delta - x_range;
                    if (x == 0 && y == 0 && z == 0)
                    {
                        hado[tt] = new double[] { 0, 0, 0, 0, tt, 0 };
                    }
                    else hado[tt] = new double[] { Math.Pow(NWF.Wf(x, y, z, n, l, m, ZZ), 2), x, y, z, tt, 0 };
                    kakuno[tt] = new double[] { 0, 0, 0, 0, 0, 0, 0, 0 };
                    saigai[tt] = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0};
                    //hado[][5] 色データ＆色情報
                    if (NWF.Wf(x, y, z, n, l, m, ZZ) < 0)
                    {
                        hado[tt][5] = 1;
                    }
                    else
                    {
                        hado[tt][5] = 0;
                    }
                    tt++;
                }
            }
        }
        //Debug.Log("tt =" + tt);

        //波動関数昇順ソート
        /*
        Array.Sort(hado, (a, b) => Math.Sign(a[0] - b[0]));
        for (int t = 0; t < tt; t++)
        {
            Debug.Log(hado[t][0] + ", " + hado[t][1] + ", " + hado[t][2] + ", " + hado[t][3] + ", " + hado[t][4]);
        }
        */

        //オブジェクト配置
        for (int o = 0; o < N * N * N; o++)
        {
            if (hado[o][0] > input_value)//== input_value)
            {
                //ユーザ入力波動関数以上の座標格納(kakuno)
                kakuno[e][0] = hado[o][0];
                kakuno[e][1] = hado[o][1];
                kakuno[e][2] = hado[o][2];
                kakuno[e][3] = hado[o][3];
                kakuno[e][7] = hado[o][5];//色
                e++;
            }
        }
        
        int u = 0;
        //最外点抽出
        //kakuno[g][4]が0より大きく、6未満であれば最外点としてメッシュの頂点にする
        //kakuno[g][5]はtriangleの2点目
        //kakuno[g][6]はtriangleの3点目
        for (int g = 0; g < e; g++)
        {
            for (int h = 0; h < e; h++)
            {
                if (g != h)//同じ頂点でなければ
                {
                    if ((kakuno[g][2] == kakuno[h][2]) && (kakuno[g][3] == kakuno[h][3]))
                    {
                        if (kakuno[g][1] == kakuno[h][1] - cp)
                        {
                            kakuno[g][4] += 1;
                        }
                        if (kakuno[g][1] == kakuno[h][1] + cp)
                        {
                            kakuno[g][4] += 1;

                        }
                    }
                    if ((kakuno[g][1] == kakuno[h][1]) && (kakuno[g][3] == kakuno[h][3]))
                    {
                        if (kakuno[g][2] == kakuno[h][2] - cp)
                        {
                            kakuno[g][4] += 1;

                        }
                        if (kakuno[g][2] == kakuno[h][2] + cp)
                        {
                            kakuno[g][4] += 1;

                        }
                    }
                    if ((kakuno[g][2] == kakuno[h][2]) && (kakuno[g][1] == kakuno[h][1]))
                    {
                        if (kakuno[g][3] == kakuno[h][3] - cp)
                        {
                            kakuno[g][4] += 1;
                        }
                        if (kakuno[g][3] == kakuno[h][3] + cp)
                        {
                            kakuno[g][4] += 1;

                        }
                    }
                }
            }
                //Debug.Log("create kakuno >> o =" + kakuno[g][0] + ", x =" + kakuno[g][1] + ", y =" + kakuno[g][2] + ", z =" + kakuno[g][3] + ", e =" + kakuno[g][4]);
                
                //Debug.Log("頂点数 =" + g );
            
            if (kakuno[g][4] > 0 && kakuno[g][4] < 6)//最外殻なら
            {
                saigai[u][0] = kakuno[g][0];
                saigai[u][1] = kakuno[g][1];
                saigai[u][2] = kakuno[g][2];
                saigai[u][3] = kakuno[g][3];
                saigai[u][7] = kakuno[g][7];
                //saigai[u][7] = -kakuno[g][1];
                //saigai[u][8] = -kakuno[g][2];
                //saigai[u][9] = -kakuno[g][3];

                u++;
                /*
                GameObject sphere = Instantiate(sphere_prefab);
                sphere.transform.position = new Mathd.Vector3d(kakuno[g][1], kakuno[g][2], kakuno[g][3]);
                sphere.name = "sphere" + g.ToString();
                */
            }
            Debug.Log("頂点数 u =" + u );
        }

        //triangles.add
        void tri_add(int a, int b)
        {
            if (saigai[a][5] != 0)
            {
                saigai[a][6] = b;

                triangles.Add(a);
                triangles.Add((int)saigai[a][5]);
                triangles.Add((int)saigai[a][6]);
                //triangles.Add(a);
                //triangles.Add((int)saigai[a][6]);
                //triangles.Add((int)saigai[a][5]);


            }
            /*
            else if (saigai[a][6] != 0)
            {
                saigai[a][7] = b;
                triangles.Add((int)saigai[a][7]);
                triangles.Add((int)saigai[a][5]);
                triangles.Add(a);

            }*/
            else saigai[a][5] = b;
        }

        void tri_6pt(int a, int b, int e,int cp)
        {
            if (saigai[a][e] == (saigai[b][e] - cp))
            {
                tri_add(a, b);
            }
            if (saigai[a][e] == (saigai[b][e] + cp))
            {
                tri_add(a, b);
            }
            if (saigai[a][e] == Math.Sqrt(2) * (saigai[b][e] - cp))
            {
                tri_add(a, b);
            }
            if (saigai[a][e] == Math.Sqrt(2) * (saigai[b][e] + cp))
            {
                tri_add(a, b);
            }
            if (saigai[a][e] == Math.Sqrt(3) * (saigai[b][e] - cp))
            {
                tri_add(a, b);
            }
            if (saigai[a][e] == Math.Sqrt(3) * (saigai[b][e] + cp))
            {
                tri_add(a, b);
            }
        }

        void tri_if_6pt(int a, int b, int c)
        {
            int d, e;
            if(c == 1)
            {
                d = 2;
                e = 3;
            }
            else if (c == 2)
            {
                d = 1;
                e = 3;
            }
            else
            {
                d = 1;
                e = 3;
            }
            if (saigai[a][d] == (saigai[b][d] - cp))
            {
                tri_6pt(a, b, e, cp);
            }
            if (saigai[a][d] == (saigai[b][d] + cp))
            {
                tri_6pt(a, b, e, cp);
            }
            if (saigai[a][d] == Math.Sqrt(2) * (saigai[b][d] - cp))
            {
                tri_6pt(a, b, e, cp);
            }
            if (saigai[a][d] == Math.Sqrt(2) * (saigai[b][d] + cp))
            {
                tri_6pt(a, b, e, cp);
            }
            if (saigai[a][d] == Math.Sqrt(3) * (saigai[b][d] - cp))
            {
                tri_6pt(a, b, e, cp);
            }
            if (saigai[a][d] == Math.Sqrt(3) * (saigai[b][d] + cp))
            {
                tri_6pt(a, b, e, cp);
            }
        }

        void four_loop(int a, int b)
        {
            for(int d = 1; d < 4 ; d++)
            {
                if (saigai[a][d] == (saigai[b][d] - cp))
                {
                    tri_if_6pt(a, b, d);
                }
                if (saigai[a][d] == (saigai[b][d] + cp))
                {
                    tri_if_6pt(a, b, d);
                }
                if (saigai[a][d] == Math.Sqrt(2) * (saigai[b][d] - cp))
                {
                    tri_if_6pt(a, b, d);
                }
                if (saigai[a][d] == Math.Sqrt(2) * (saigai[b][d] + cp))
                {
                    tri_if_6pt(a, b, d);
                }
                if (saigai[a][d] == Math.Sqrt(3) * (saigai[b][d] - cp))
                {
                    tri_if_6pt(a, b, d);
                }
                if (saigai[a][d] == Math.Sqrt(3) * (saigai[b][d] + cp))
                {
                    tri_if_6pt(a, b, d);
                }
            }
        }
        
        //saigai[][8]作成
        void mk8(int a, int b,int cp)
        {
            int zon = 0;
            int krt = 0;
            int mj = 0;
            if (saigai[a][6] != 0)
            {
                for (int lol = 1; lol < 4; lol++)
                {
                    if (lol == 1)
                    {
                        zon = 1;
                        krt = 2;
                        mj = 3;
                    }
                    else if (lol == 2)
                    {
                        zon = 2;
                        krt = 3;
                        mj = 1;
                    }
                    else
                    {
                        zon = 3;
                        krt = 1;
                        mj = 2;
                    }
                    if (saigai[a][zon] == saigai[b][zon] - cp)
                    {
                        if (saigai[a][krt] == saigai[b][krt] - cp)
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][krt] == saigai[b][krt] + cp)
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][krt] == Math.Sqrt(2) * (saigai[b][krt] - cp))
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][krt] == Math.Sqrt(2) * (saigai[b][krt] + cp))
                        {
                            saigai[a][8] = b;
                        }
                    }
                    if (saigai[a][zon] == saigai[b][zon] + cp)
                    {
                        if (saigai[a][krt] == saigai[b][krt] - cp)
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][krt] == saigai[b][krt] + cp)
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][krt] == Math.Sqrt(2) * (saigai[b][krt] - cp))
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][krt] == Math.Sqrt(2) * (saigai[b][krt] + cp))
                        {
                            saigai[a][8] = b;
                        }
                    }
                    if (saigai[a][zon] == saigai[b][zon] - cp)
                    {
                        if (saigai[a][mj] == saigai[b][mj] - cp)
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][mj] == saigai[b][mj] + cp)
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][mj] == Math.Sqrt(2) * (saigai[b][mj] - cp))
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][mj] == Math.Sqrt(2) * (saigai[b][mj] + cp))
                        {
                            saigai[a][8] = b;
                        }
                    }
                    if (saigai[a][zon] == saigai[b][zon] + cp)
                    {
                        if (saigai[a][mj] == saigai[b][mj] - cp)
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][mj] == saigai[b][mj] + cp)
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][mj] == Math.Sqrt(2) * (saigai[b][mj] - cp))
                        {
                            saigai[a][8] = b;
                        }
                        if (saigai[a][mj] == Math.Sqrt(2) * (saigai[b][mj] + cp))
                        {
                            saigai[a][8] = b;
                        }
                    }
                }
            }
        }

        //メッシュ頂点インデックス作成
        for (int a = 0; a < u; a++)
        {
            for (int b = 0; b < u; b++)
            {
                if (a != b)//同じ頂点でなければ
                {
                    if ((saigai[a][2] == saigai[b][2]) && (saigai[a][3] == saigai[b][3]))
                    {
                        if (saigai[a][1] == (saigai[b][1] - cp))
                        {
                            saigai[a][5] = b;
                        }
                        if (saigai[a][1] ==  (saigai[b][1] + cp))
                        {
                            tri_add(a, b);
                        }
                        if (saigai[a][1] == Math.Sqrt(2) * (saigai[b][1] - cp))
                        {
                            tri_add(a, b);
                        }
                        if (saigai[a][1] == Math.Sqrt(2) * (saigai[b][1] + cp))
                        {
                            tri_add(a, b);
                        }
                    }
                    if ((saigai[a][1] == saigai[b][1]) && (saigai[a][3] == saigai[b][3]))
                    {
                        if (saigai[a][2] ==  (saigai[b][2] - cp))
                        {
                            tri_add(a, b);
                        }
                        if (saigai[a][2] ==  (saigai[b][2] + cp))
                        {
                            tri_add(a, b);
                        }
                        if (saigai[a][2] == Math.Sqrt(2) * (saigai[b][2] - cp))
                        {
                            tri_add(a, b);
                        }
                        if (saigai[a][2] == Math.Sqrt(2) * (saigai[b][2] + cp))
                        {
                            tri_add(a, b);
                        }
                    }
                    if ((saigai[a][2] == saigai[b][2]) && (saigai[a][1] == saigai[b][1]))
                    {
                        if (saigai[a][3] ==  (saigai[b][3] - cp))
                        {
                            tri_add(a, b);

                        }
                        if (saigai[a][3] ==  (saigai[b][3] + cp))
                        {
                            tri_add(a, b);

                        }
                        if (saigai[a][3] == Math.Sqrt(2) * (saigai[b][3] - cp))
                        {
                            tri_add(a, b);
                        }
                        if (saigai[a][3] == Math.Sqrt(2) * (saigai[b][3] + cp))
                        {
                            tri_add(a, b);
                        }
                    }
                    if (saigai[a][2] == saigai[b][2])
                    {
                        tri_if_6pt(a, b, 2);
                    }
                    if (saigai[a][3] == saigai[b][3])
                    {
                        tri_if_6pt(a, b, 3);
                    }
                    if (saigai[a][1] == saigai[b][1])
                    {
                        tri_if_6pt(a, b, 1);   
                    }
                    four_loop(a, b);
                    /*
                    mk8(a, b, cp);
                    triangles.Add(a);
                    triangles.Add((int)saigai[a][5]);
                    triangles.Add((int)saigai[a][6]);
                    triangles.Add(a);
                    triangles.Add((int)saigai[a][6]);
                    triangles.Add((int)saigai[a][8]);
                    */
                }
            }
        }
        
        //vertex.add
        for (int v = 0; v < u; v++)
        {
            //頂点としてvertex.addする
            /*
            GameObject sphere = Instantiate(sphere_prefab);
            sphere.transform.position = new UnityEngine.Vector3((float)saigai[v][1] , (float)saigai[v][2] - 2 , (float)saigai[v][3] );
            sphere.name = "sphere" + v.ToString();
            */
            vertices.Add(new UnityEngine.Vector3((float)saigai[v][1], (float)saigai[v][2], (float)saigai[v][3]));//頂点の位置
        }

        mesh.SetVertices(vertices);         // メッシュに頂点を登録する
        mesh.SetTriangles(triangles, 0);    // メッシュにインデックスリストを登録する
        mesh.SetIndices(triangles, MeshTopology.Triangles, 0); //MeshTopologyを変更すればラインや点群といった表示もできる
        mesh.RecalculateNormals();          // 法線の再計算
        mesh.name = "RadialMesh";
        _meshFilter.mesh = mesh;
        
        // 頂点カラーの配列を作成
        Color[] vertexColors = new Color[u];
        //Debug.Log("vertexCount =" + mesh.vertexCount);

        // 頂点がPlaneのどちら側にあるかによって頂点カラーを変える

        for (int ti = 0; ti < u ; ti++)
        {
            // 色
            if (saigai[ti][7] == 1)
            {
                vertexColors[ti] = Color.red;
            }
            else
            {
                vertexColors[ti] = Color.blue;
            }
            Debug.Log("ti =" + ti);
        }
        
        // メッシュに頂点カラーを設定
        mesh.colors = vertexColors;
        
        Debug.Log("波動関数 " + input_value + "　以上表示");
        //Debug.Log("頂点数　" + e + "個");
    }


    void Update()
            {
                //色付けのルール
                /*
                if (NWF.Get_Real(NWF.Euler_Angle_THETA(x, y, z), NWF.Euler_Angle_PHI(x, y, z), l, m) > 0)
                {
                    sphere.GetComponent<Renderer>().material.color = Color.red;
                    //Debug.Log("Red" + tt);
                }
                else
                {
                    sphere.GetComponent<Renderer>().material.color = Color.blue;
                    //Debug.Log("Blue" + tt);
                }*/

        }
    }
    

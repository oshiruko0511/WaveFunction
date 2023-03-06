using System;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;
using Mathd;
using UnityEngine;
using UnityEngine.Internal;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]

public class MeshManager : MonoBehaviour
{
    public float directionX;
    public float directionY;
    public float directionZ;
    public GameObject blueCube;

    public int l = 2;
    public int m = -2;
    public double size = 100;
    public int yy = 200;
    public int xx = 200;

    private Mesh _mesh;
    private MeshFilter _meshFilter;

    // Start is called before the first frame update
    void Start()
    {
        directionX = 0; 
        directionY = 0; 
        directionZ = 0;
        transform.Rotate(directionX, directionY, directionZ);
        blueCube = GameObject.Find("Arrow");
        _mesh = GetComponent<Mesh>();
        _meshFilter = GetComponent<MeshFilter>();
        CreateWFMesh();
    }
    void Update()
    {   //メッシュを回転させる
        directionX = 0;
        directionY = 0;
        directionZ = 0;
        transform.Rotate(directionX, directionY, directionZ);
        blueCube.GetComponent<SameRotate>().RightRotate();
        //transform.Rotate(new UnityEngine.Vector3(0.5f, 0.5f, 0.5f));
        //transform.Rotate(new UnityEngine.Vector3(x, y, z));
    }

    public void CreateWFMesh()
    {
        List<UnityEngine.Vector3> vertices = new List<UnityEngine.Vector3>();
        List<int> triangles = new List<int>();

        Mesh mesh = new Mesh(); // メッシュを作成
        mesh.Clear();

        double u = 0, w = 0;
        double[,] F = new double[yy, xx];
        double[,] X = new double[yy, xx];
        double[,] Y = new double[yy, xx];
        double[,] Z = new double[yy, xx];

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
        int co = 0;
        for (int y = 0; y < yy; y++)
        {
            for (int x = 0; x < xx; x++)
            {
                F[y, x] = Math.Pow(WF.Get_Real(THETA[x], PHI[y], l, m), 2);
                X[y, x] = size * F[y, x] * Math.Sin(THETA[x]) * Math.Cos(PHI[y]);
                Y[y, x] = size * F[y, x] * Math.Sin(THETA[x]) * Math.Sin(PHI[y]);
                Z[y, x] = size * F[y, x] * Math.Cos(THETA[x]);
                //Debug.Log("X[" + y + "," + x + "] =" + X[y, x] + " Y =" + Y[y, x] + " Z =" + Z[y, x]);
                vertices.Add(new UnityEngine.Vector3((float)X[y, x], (float)Y[y, x], (float)Z[y, x]));//頂点の位置
                co++;
            }
        }
        //Debug.Log("co =" + co);

        if (m == 0)//m==0の先が潰れる修正用頂点
        {
            vertices.Add(new UnityEngine.Vector3((float)X[0, 0], (float)Y[0, 0], -(float)Z[0, 0]));
        }

        void one_four(int p)
        {
            if (p % xx == 0)//0
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(p + xx);
            }
            else if (p % xx == (xx / 2 - 1))//4
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p + xx);
                triangles.Add(p + xx - 1);
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(p + xx);
            }
            else //(p % xx < (xx / 2 - 1) && p % xx > 0) 1,2,3
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p + xx);
                triangles.Add(p + xx - 1);
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(p + xx);
            }
        }

        void five_nine(int p)
        {
            if (p % xx == (xx / 2))//5
            {
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(p + xx);
                triangles.Add(p);
                triangles.Add(p + xx);
                triangles.Add(p + xx - 1);
            }
            else if (p % xx == (xx - 1))//9
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p + xx);
                triangles.Add(p + xx - 1);
                if (m == 0)
                {
                    triangles.Add(p);
                    triangles.Add(xx * yy);
                    triangles.Add(p + xx);
                }
            }
            else//6,7,8
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p + xx);
                triangles.Add(p + xx - 1);
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(p + xx);
            }
        }

        void ninety_one_four(int p)
        {
            if (p % xx == 0)//0
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(0);
            }
            else if (p % xx == (xx / 2 - 1))//4
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p % xx);
                triangles.Add(p % xx - 1);
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(p - xx * (yy - 1));
            }
            else //(p % xx < (xx / 2 - 1) && p % xx > 0) 1,2,3
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p % xx);
                triangles.Add(p % xx - 1);
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(p % xx);
            }
        }

        void ninety_five_nine(int p)
        {
            if (p % xx == (xx / 2))//5
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(p - xx * (yy - 1));
                triangles.Add(p);
                triangles.Add(p - xx * (yy - 1));
                triangles.Add(p - xx * (yy - 1) - 1);
            }
            else if (p % xx == (xx - 1))//9
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p % xx);
                triangles.Add(p % xx - 1);
                if (m == 0)
                {
                    triangles.Add(p);
                    triangles.Add(xx * yy);
                    triangles.Add(p - xx * (yy - 1));
                }
            }
            else //(p % xx < (xx / 2 - 1) && p % xx > 0) 6,7,8
            {
                //Debug.Log("p =" + p);
                triangles.Add(p);
                triangles.Add(p % xx);
                triangles.Add(p % xx - 1);
                triangles.Add(p);
                triangles.Add(p + 1);
                triangles.Add(p % xx);
            }
        }

        //頂点インデックスを作成
        for (int p = 0; p < yy * xx; p++)//0から89まで
        {
            if (p % xx <= (xx / 2 - 1))
            {
                if (p < xx * yy && p >= xx * (yy - 1))//((xx * yy * 0.2 <= p && xx * yy * 0.3 > p) || (xx * yy * 0.4 <= p && xx * yy * 0.5 > p))
                {
                    ninety_one_four(p);
                }
                else
                {
                    one_four(p);
                }
            }
            else
            {
                if (p < xx * yy && p >= xx * (yy - 1)) //((xx * yy * 0.2 <= p && xx * yy * 0.3 > p) || (xx * yy * 0.4 <= p && xx * yy * 0.5 > p))
                {
                    ninety_five_nine(p);
                }
                else
                {
                    five_nine(p);
                }
            }
            //Debug.Log("p =" + p);
        }
        // メッシュ初期化
        
        mesh.SetVertices(vertices);         // メッシュに頂点を登録する
        mesh.SetTriangles(triangles, 0);    // メッシュにインデックスリストを登録する
        mesh.SetIndices(triangles, MeshTopology.Triangles, 0); //MeshTopologyを変更すればラインや点群といった表示もできる
        mesh.RecalculateNormals();          // 法線の再計算
        mesh.name = "WFMesh";
        _meshFilter.mesh = mesh;

        int ll;
        if(m == 0)
        {
            ll = 1;
        }
        else { ll = 0; }

        // 頂点カラーの配列を作成
        Color[] vertexColors = new Color[xx * yy + ll];
        //Debug.Log("vertexCount =" + mesh.vertexCount);
        
        // 頂点がPlaneのどちら側にあるかによって頂点カラーを変える
        int i = 0;
        for (int y = 0; y < yy; y++)
        {
            for (int x = 0; x < xx; x++)
            {
                // 色
                if (WF.Get_Real(THETA[x], PHI[y], l, m) > 0)
                {
                    vertexColors[i] = Color.red;
                }
                else
                {
                    vertexColors[i] = Color.blue;
                }
                i++;
            }
        }
        if(m == 0)
        {
            if (WF.Get_Real(THETA[0], PHI[0], l, m) > 0)
            {
                vertexColors[i] = Color.red;
            }
            else
            {
                vertexColors[i] = Color.blue;
            }
            i++;
        }
        //Debug.Log("i =" + i);
        // メッシュに頂点カラーを設定
        mesh.colors = vertexColors;
    }
}
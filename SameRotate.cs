using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SameRotate : MonoBehaviour
{
    GameObject greenCube;
    MeshManager cubeRotate;
    //CubeRotate cubeRotate;

    void Start()
    {
        //greenCube = GameObject.Find("GreenCube");
        greenCube = GameObject.Find("GameManager");
        cubeRotate = greenCube.GetComponent<MeshManager>();
        //cubeRotate = greenCube.GetComponent<CubeRotate>();
    }

    public void RightRotate()
    {
        transform.Rotate(cubeRotate.directionX, cubeRotate.directionY, cubeRotate.directionZ);
    }

    public void LeftRotate()
    {
        transform.Rotate(0, cubeRotate.directionY, 0);
    }
}
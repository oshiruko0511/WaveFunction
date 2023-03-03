using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public float direction;
    public GameObject blueCube;

    void Start()
    {
        direction = 0;
        blueCube = GameObject.Find("BlueCube");
    }

    void Update()
    {
        direction = 0.5f;
        transform.Rotate(direction, direction, direction);
        blueCube.GetComponent<SameRotate>().RightRotate();
    }
}
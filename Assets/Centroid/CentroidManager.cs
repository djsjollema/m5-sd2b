using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentroidManager : MonoBehaviour
{
    public DragablePoint A;
    public DragablePoint B;
    public GameObject AB;
    private LineRenderer lAB;

    void Start()
    {
        lAB = AB.GetComponent<LineRenderer>();
    }

    void Update()
    {
        lAB.SetPosition(0, new Vector3(-10, -10, 0));
        lAB.SetPosition(1, new Vector3(10, 10, 0));  
    }
}

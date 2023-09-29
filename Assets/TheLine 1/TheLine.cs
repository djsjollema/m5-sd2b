using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheLine : MonoBehaviour
{
    public DragablePoint A;
    public DragablePoint B;
    public GameObject line;
    private LineRenderer lr;
    private LinearFunction f;

    // Start is called before the first frame update
    void Start()
    {
        f = new LinearFunction(2,3);
        lr = line.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        f.LineTroughTwoPoint(A.transform.position, B.transform.position);
        lr.SetPosition(0, new Vector3(-20, f.getY(-20), 0));
        lr.SetPosition(1, new Vector3(20, f.getY(20), 0));
        
    }
}

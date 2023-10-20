using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrthoManger : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public Transform C;
    private LinearFunction AB = new LinearFunction(1, 1);
    public LineRenderer lineAB;

    private LinearFunction pAB = new LinearFunction(1, 1);
    public LineRenderer line_pAB;

    void Start()
    {
        
    }

    void Update()
    {
        AB.LineTroughTwoPoint(A.position, B.position);
        lineAB.SetPosition(0, new Vector3(-20, AB.getY(-20), 0));
        lineAB.SetPosition(1, new Vector3(20, AB.getY(20), 0));

        pAB.slope = -1 / AB.slope;
        pAB.intercept = C.position.y - pAB.slope * C.position.x;
        line_pAB.SetPosition(0, new Vector3(-20, pAB.getY(-20), 0));
        line_pAB.SetPosition(1, new Vector3(20, pAB.getY(20), 0));

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentroidManager : MonoBehaviour
{
    public DragablePoint A;
    public DragablePoint B;
    public DragablePoint C;

    public GameObject AB;
    public GameObject AC;
    public GameObject BC;

    private LineRenderer lAB;
    private LineRenderer lAC;
    private LineRenderer lBC;

    private LinearFunction fAB = new LinearFunction(1,0);
    private LinearFunction fBC = new LinearFunction(1,0);
    private LinearFunction fAC  = new LinearFunction(1,0);

    public GameObject hAB;
    public GameObject hAC;

    private LinearFunction fhABC = new LinearFunction(1,0);
    private LinearFunction fhACB = new LinearFunction(1,0);

    public GameObject hABC;
    public GameObject hACB;

    private LineRenderer lhABC;
    private LineRenderer lhACB;

    public GameObject centroid;


    void Start()
    {
        lAB = AB.GetComponent<LineRenderer>();
        lAC = AC.GetComponent<LineRenderer>();
        lBC = BC.GetComponent<LineRenderer>();
        lhABC = hABC.GetComponent<LineRenderer>();
        lhACB = hACB.GetComponent<LineRenderer>();  
    }

    void Update()
    {
        fAB.LineTroughTwoPoint(A.transform.position, B.transform.position);
        lAB.SetPosition(0, new Vector3(-10, fAB.getY(-10), 0));
        lAB.SetPosition(1, new Vector3(10, fAB.getY(10), 0));

        fAC.LineTroughTwoPoint(A.transform.position, C.transform.position);
        lAC.SetPosition(0, new Vector3(-10, fAC.getY(-10), 0));
        lAC.SetPosition(1, new Vector3(10, fAC.getY(10), 0));

        fBC.LineTroughTwoPoint(B.transform.position, C.transform.position);
        lBC.SetPosition(0, new Vector3(-10, fBC.getY(-10), 0));
        lBC.SetPosition(1, new Vector3(10, fBC.getY(10), 0));

        //hAB.transform.position = new Vector3((A.transform.position.x + B.transform.position.x) / 2, (A.transform.position.y + B.transform.position.y) / 2, 0);
        hAB.transform.position = (A.transform.position + B.transform.position)/2;
        hAC.transform.position = new Vector3((A.transform.position.x + C.transform.position.x) / 2, (A.transform.position.y + C.transform.position.y) / 2, 0);

        fhABC.LineTroughTwoPoint(hAB.transform.position, C.transform.position);
        

        lhABC.SetPosition(0, new Vector3(-10,fhABC.getY(-10), 0));
        lhABC.SetPosition(1, new Vector3(10, fhABC.getY(10), 0));

        fhACB.LineTroughTwoPoint(hAC.transform.position, B.transform.position);
        lhACB.SetPosition(0, new Vector3(-10, fhACB.getY(-10), 0));
        lhACB.SetPosition(1, new Vector3(10, fhACB.getY(10), 0));

        centroid.transform.position = fhABC.intersectionPoint(fhACB);
    }

}

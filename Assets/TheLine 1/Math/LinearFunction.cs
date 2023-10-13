using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearFunction 
{
    private float slope;
    private float intercept;

    public LinearFunction(float slope, float intercept)
    {
        this.slope = slope;
        this.intercept = intercept;
    }

    public float getY(float x)
    {
        return slope * x + intercept; 
    }

    public void LineTroughTwoPoint(Vector3 A, Vector3 B)
    {
        this.slope = (B.y - A.y)/(B.x - A.x);
        this.intercept = B.y - this.slope * B.x;
    }

    public Vector3 intersectionPoint(LinearFunction l)
    {
        Vector3 iPoint = Vector3.zero;
        iPoint.x = (l.intercept - this.intercept)/(this.slope - l.slope);
        iPoint.y = this.slope * iPoint.x + this.intercept;
        return iPoint;

    }

}

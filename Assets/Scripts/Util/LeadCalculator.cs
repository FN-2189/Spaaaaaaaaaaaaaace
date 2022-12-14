using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadCalculator : MonoBehaviour
{
    public static Vector3? CaculateLead(Vector3 relV, Vector3 pos, Vector3 targetPos, float bulletV) // it no work AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    {
        Vector3 q = targetPos - pos;

        //solving quadratic equation from t*t(Vx*Vx + Vy*Vy - S*S) + 2*t*(Vx*Qx)(Vy*Qy) + Qx*Qx + Qy*Qy = 0

        float a = Vector3.Dot(relV, relV) - (bulletV * bulletV); //Dot is basicly (targetSpeed.x * targetSpeed.x) + (targetSpeed.y * targetSpeed.y)
        float b = 2 * Vector3.Dot(relV, q); //Dot is basicly (targetSpeed.x * q.x) + (targetSpeed.y * q.y)
        float c = Vector3.Dot(q, q); //Dot is basicly (q.x * q.x) + (q.y * q.y)

        //Discriminant
        float D = Mathf.Sqrt((b * b) - 4 * a * c);

        float t1 = (-b + D) / (2 * a);
        float t2 = (-b - D) / (2 * a);

        //Debug.Log("t1: " + t1 + " t2: " + t2);


        // if none are positive or a NaN return null
        if (float.IsNaN(t1) && float.IsNaN(t2)) return null;
        if(t1 < 0f && t2 < 0f) return null;

        float time = 0f;

        // return the positive number if one is negative
        if (t1 < 0f) time = t2;
        else if (t2 < 0f) time = t1;

        // return the smallest of the two if both are positive
        else time = Mathf.Min(t1, t2);

        Vector3 ret = targetPos + relV * time;
        return ret;
    }
}

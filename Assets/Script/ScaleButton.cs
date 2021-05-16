using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleButton : MonoBehaviour
{
    readonly float SLA = 1f;
    readonly float SLB = 0.8f;
    readonly float SLC = 0.6f;
    readonly float SLD = 0.4f;
    readonly float SLE = 0.2f;

    public void ButtonScalA()
    {
       transform.localScale = new Vector3(SLA,SLA,SLA);
    }
    public void ButtonScalB()
    {
        transform.localScale = new Vector3(SLB, SLB, SLB);
    }
    public void ButtonScalC()
    {
        transform.localScale = new Vector3(SLC, SLC, SLC);
    }
    public void ButtonScalD()
    {
        transform.localScale = new Vector3(SLD, SLD, SLD);
    }
    public void ButtonScalE()
    {
        transform.localScale = new Vector3(SLE, SLE, SLE);
    }
}

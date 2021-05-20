using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exponential : AxisTransferfunction
{
    public float sensitivity = 1f;
    public float exponentialTransferFunctionPower = 1.53f;

    public override float GetAxisInput()
    {
        float axis = input.GetAxisInput();
        axis =  Mathf.Sign(axis) * Mathf.Pow(Mathf.Abs(axis) * sensitivity, exponentialTransferFunctionPower);
        return axis;
    }
}

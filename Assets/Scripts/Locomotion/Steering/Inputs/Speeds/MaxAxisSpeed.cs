using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MaxAxisSpeed : SpeedInput
{
    public override float GetSpeed()
    {
        float result = 0f;
        
        foreach (var elem in inputs)
        {
            if (Mathf.Abs(elem.GetAxisInput()) > result)
            {
                result = Mathf.Abs(elem.GetAxisInput());
            }
        }
        return result;
    }
}

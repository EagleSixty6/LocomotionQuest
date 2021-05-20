using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YawRotation : DirectionInput
{
    public override Vector3 GetDirectionInput()
    {
        return new Vector3(0,1, 0);
    }
}

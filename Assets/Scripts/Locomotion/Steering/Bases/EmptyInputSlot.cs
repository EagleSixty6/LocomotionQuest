using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyInputSlot : AxisInput
{
    public override float GetAxisInput()
    {
        return 0f;
    }
}

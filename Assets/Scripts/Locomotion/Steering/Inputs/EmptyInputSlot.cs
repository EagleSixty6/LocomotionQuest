using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyInputSlot : IAxisInput
{
    public override float GetAxis()
    {
        return 0f;
    }
}

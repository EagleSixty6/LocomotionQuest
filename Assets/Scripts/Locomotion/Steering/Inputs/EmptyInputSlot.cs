using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyInputSlot : IAxisInput
{
    public override float Get()
    {
        return 0f;
    }
}

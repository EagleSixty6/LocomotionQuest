using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpeedInput : AxisInput
{
    public List<AxisInput> inputs;

    public abstract override float GetAxisInput();
}

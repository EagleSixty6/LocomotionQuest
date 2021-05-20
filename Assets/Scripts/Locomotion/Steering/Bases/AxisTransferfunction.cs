using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AxisTransferfunction : IProvidesAxisInput
{
    public AxisInput input;
    public abstract float GetAxisInput();
}

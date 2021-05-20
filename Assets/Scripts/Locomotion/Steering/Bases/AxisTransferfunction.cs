using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AxisTransferfunction : AxisInput, IProvidesAxisInput
{
    public AxisInput input;
    public abstract override float GetAxisInput();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AxisInput : MonoBehaviour, IProvidesAxisInput
{
    public abstract float GetAxisInput();
}

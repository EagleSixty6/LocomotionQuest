using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpeedInput : MonoBehaviour, IProvidesSpeedInput
{
    public List<AxisInput> inputs;
    
    public abstract float GetSpeed();
}

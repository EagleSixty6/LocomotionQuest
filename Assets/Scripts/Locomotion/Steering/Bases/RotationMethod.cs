using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RotationMethod : MonoBehaviour
{
    public AxisInput rollAxis;
    public AxisInput yawAxis;
    public AxisInput pitchAxis;

    void Start()
    {
        if (rollAxis == null)
        {
            rollAxis = this.gameObject.AddComponent<EmptyInputSlot>();
        }

        if (yawAxis == null)
        {
            yawAxis = this.gameObject.AddComponent<EmptyInputSlot>();
        }

        if (pitchAxis == null)
        {
            pitchAxis = this.gameObject.AddComponent<EmptyInputSlot>();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IRotationMethod : MonoBehaviour
{
    public IAxisInput rollAxis;
    public IAxisInput yawAxis;
    public IAxisInput pitchAxis;

    void Start()
    {
        if (rollAxis == null)
        {
            rollAxis = new EmptyInputSlot();
        }

        if (yawAxis == null)
        {
            yawAxis = new EmptyInputSlot();
        }

        if (pitchAxis == null)
        {
            pitchAxis = new EmptyInputSlot();
        }
    }
}
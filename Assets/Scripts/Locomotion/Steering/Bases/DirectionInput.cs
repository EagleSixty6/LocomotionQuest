using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DirectionInput : MonoBehaviour, IProvidesDirectionInput
{
    public AxisInput forwardAxis;
    public AxisInput rightAxis;
    public AxisInput upAxis;
    
    // This has to be a global direction
    public abstract Vector3 GetDirectionInput();
    
    void Start()
    {
        if (forwardAxis == null)
        {
            forwardAxis = this.gameObject.AddComponent<EmptyInputSlot>();
        }

        if (rightAxis == null)
        {
            rightAxis = this.gameObject.AddComponent<EmptyInputSlot>();
        }

        if (upAxis == null)
        {
            upAxis = this.gameObject.AddComponent<EmptyInputSlot>();
        }
    }
}

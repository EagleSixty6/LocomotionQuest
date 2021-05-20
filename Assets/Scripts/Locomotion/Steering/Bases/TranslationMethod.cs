using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TranslationMethod : MonoBehaviour
{
    public AxisInput forwardAxis;
    public AxisInput rightAxis;
    public AxisInput upAxis;

    public AxisInput speedAxis;
    
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
        
        if (speedAxis == null)
        {
            speedAxis = this.gameObject.AddComponent<EmptyInputSlot>();
        }
    }
}

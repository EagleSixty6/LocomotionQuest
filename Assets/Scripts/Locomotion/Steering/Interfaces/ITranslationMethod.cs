using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ITranslationMethod : MonoBehaviour
{
    public IAxisInput forwardAxis;
    public IAxisInput rightAxis;
    public IAxisInput upAxis;

    public IAxisInput speedAxis;
    
    void Start()
    {
        if (forwardAxis == null)
        {
            forwardAxis = new EmptyInputSlot();
        }

        if (rightAxis == null)
        {
            rightAxis = new EmptyInputSlot();
        }

        if (upAxis == null)
        {
            upAxis = new EmptyInputSlot();
        }
        
        if (speedAxis == null)
        {
            speedAxis = new EmptyInputSlot();
        }
    }
}

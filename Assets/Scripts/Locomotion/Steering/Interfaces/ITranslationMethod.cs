using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ITranslationMethod : MonoBehaviour
{
    public IAxisInput forwardAxis;
    public IAxisInput sidewayAxis;
    public IAxisInput upAxis;

    void Start()
    {
        if (forwardAxis == null)
        {
            forwardAxis = new EmptyInputSlot();
        }

        if (sidewayAxis == null)
        {
            sidewayAxis = new EmptyInputSlot();
        }

        if (upAxis == null)
        {
            upAxis = new EmptyInputSlot();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRelativeX : IAxisInput
{
    public override float GetAxis()
    {
        // relative position to bottom left corner [0,1]
        float relativePosition = Input.mousePosition.x / Screen.width;

        // relative postion to screen mid [-1, 1]
        relativePosition = (relativePosition - 0.5f) * 2f;
        
        // clamp to [-1, 1] in case of multi-screen setups
        relativePosition = Mathf.Clamp(relativePosition, -1, 1);
        
        return relativePosition;
    }
}

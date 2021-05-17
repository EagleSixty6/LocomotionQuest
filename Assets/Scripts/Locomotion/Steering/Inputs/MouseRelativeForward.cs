using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRelativeForward : IAxisInput
{
    public override float GetAxis()
    {
        return Input.mousePosition.y / Screen.height;
    }
}

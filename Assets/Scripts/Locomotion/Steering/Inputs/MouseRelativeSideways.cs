using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRelativeSideways : IAxisInput
{
    public override float GetAxis()
    {
        return Input.mousePosition.x / Screen.width;
    }
}

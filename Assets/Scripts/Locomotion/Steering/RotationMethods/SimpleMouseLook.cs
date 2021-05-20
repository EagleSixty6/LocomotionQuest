using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMouseLook : RotationMethod
{
    public float maxTurningAngle = 90;

    void Update()
    {
        transform.rotation = Quaternion.AngleAxis(maxTurningAngle * rotationSpeed.GetAxisInput(), axis.GetDirectionInput());
    }
}

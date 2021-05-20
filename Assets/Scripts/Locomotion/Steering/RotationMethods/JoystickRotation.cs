using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickRotation : RotationMethod
{
    public float maxSpeedPerAxis = 90;
    
    void Update()
    {
        transform.Rotate(axis.GetDirectionInput(), rotationSpeed.GetAxisInput() * Time.deltaTime * maxSpeedPerAxis);
    }
}

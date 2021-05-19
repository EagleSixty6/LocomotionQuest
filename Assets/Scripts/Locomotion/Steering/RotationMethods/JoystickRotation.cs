using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickRotation : IRotationMethod
{
    public float maxSpeed = 1;
    
    void Update()
    {
        // TODO catch summed speed
        transform.Rotate(0,yawAxis.GetAxis() * maxSpeed * Time.deltaTime,0 ); 
    }
}

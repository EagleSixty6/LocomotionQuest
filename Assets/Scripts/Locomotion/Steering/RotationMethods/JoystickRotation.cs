using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickRotation : IRotationMethod
{
    public float maxSpeedPerAxis = 90;
    
    void Update()
    {
        //transform.Rotate(0, yawAxis.GetAxis() * maxSpeed * Time.deltaTime,0 );
        
        Vector3 eulers = transform.eulerAngles;
        eulers.y = eulers.y + yawAxis.Get() * maxSpeedPerAxis * Time.deltaTime;
        transform.rotation = Quaternion.Euler(eulers);
        
        eulers = transform.eulerAngles;
        eulers.x = eulers.x + pitchAxis.Get() * maxSpeedPerAxis * Time.deltaTime;
        transform.rotation = Quaternion.Euler(eulers);
        
        eulers = transform.eulerAngles;
        eulers.z = eulers.z + rollAxis.Get() * maxSpeedPerAxis * Time.deltaTime;
        transform.rotation = Quaternion.Euler(eulers);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMouseLook : RotationMethod
{
    public float pitchTurningLimit = 90;
    public float yawTurningLimit = 180;
    public float rollTurningLimit = 90;
    
    void Update()
    {
        transform.eulerAngles = new Vector3( pitchAxis.GetAxisInput() * pitchTurningLimit , yawAxis.GetAxisInput() * yawTurningLimit, rollAxis.GetAxisInput() * rollTurningLimit);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardForward : IAxisInput
{
    private float axis;

    void Update()
    {
        float temp = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            temp += 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            temp += -1;
        }
        
        axis = temp;
    }
    
    public override float GetAxis()
    {
        return axis;
    }
}

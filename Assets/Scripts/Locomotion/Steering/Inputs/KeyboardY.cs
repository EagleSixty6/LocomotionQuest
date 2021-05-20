using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardY : AxisInput
{
    private float axis;

    void Update()
    {
        float temp = 0f;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            temp += 1;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            temp += -1;
        }
        
        axis = temp;
    }
    
    public override float GetAxisInput()
    {
        return axis;
    }
}

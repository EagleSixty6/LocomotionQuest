using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardX : IAxisInput
{
    private float axis;

    void Update()
    {
        float temp = 0f;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            temp += -1;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            temp += 1;
        }
        
        axis = temp;
    }
    
    public override float GetAxis()
    {
        return axis;
    }
}

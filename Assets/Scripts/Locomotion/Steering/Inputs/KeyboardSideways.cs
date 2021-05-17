using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardSideways : IAxisInput
{
    private float axis;

    void Update()
    {
        float temp = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            temp += -1;
        }

        if (Input.GetKey(KeyCode.D))
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

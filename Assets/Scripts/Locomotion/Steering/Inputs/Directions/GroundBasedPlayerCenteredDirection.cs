using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBasedPlayerCenteredDirection : DirectionInput
{
    public override Vector3 GetDirectionInput()
    {
        Vector3 direction = new Vector3(rightAxis.GetAxisInput(), upAxis.GetAxisInput(), forwardAxis.GetAxisInput());
        
        // in case the direction input source serves a 3D input, better normalize to "ground"
        direction = Vector3.ProjectOnPlane(direction.normalized, Vector3.up);
        
        // the solution is a local direction in player coordinate system, thus we have to transform this to world coordinates
        direction = transform.TransformDirection(direction);

        return direction;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickTranslation : ITranslationMethod
{
    public float maxSpeed;
    
    void Update()
    {
        Vector3 direction = new Vector3(sidewayAxis.GetAxis(), upAxis.GetAxis(), forwardAxis.GetAxis());
        
        // in case the direction input source serves a 3D input, better normalize to "ground"
        direction = Vector3.ProjectOnPlane(direction.normalized, Vector3.up);
        
        // the solution is a local direction in keyboard coordinate system, thus we have to transform this to world coordinates
        direction = transform.TransformDirection(direction);
        
        // frame rate independet, iterativbe movement of the player platform
        transform.position += 1f * maxSpeed * Time.deltaTime * direction;
    }
}

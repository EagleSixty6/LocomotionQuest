using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickTranslation : TranslationMethod
{
    public float maxSpeed;
    
    void Update()
    {
        // frame rate independet, iterativbe movement of the player platform
        transform.position += speed.GetSpeed() * maxSpeed * Time.deltaTime * dir.GetDirectionInput();
    }
}

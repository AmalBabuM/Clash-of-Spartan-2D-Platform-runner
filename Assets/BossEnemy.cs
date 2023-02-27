using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    // Set this to true to flip the object horizontally
    public bool flipX;

    void Update()
    {
        // Get the current local scale of the object
        Vector3 scale = transform.localScale;

        // If flipX is true, flip the object horizontally by setting the x scale to its negative value
        if (flipX)
        {
            scale.x = -Mathf.Abs(scale.x);
        }
        else // Otherwise, set the x scale to its original value
        {
            scale.x = Mathf.Abs(scale.x);
        }

        // Set the new local scale of the object
        transform.localScale = scale;
    }
}

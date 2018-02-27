using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationClamp : MonoBehaviour {

    public Vector2 rotationBoundaries = new Vector2(45f, 280f);

    private void LateUpdate()
    {
        float zRotation = transform.localEulerAngles.z;
        if(zRotation >= rotationBoundaries.x && zRotation <= rotationBoundaries.y)
        {
            transform.rotation = zRotation >= 180f ? transform.rotation = Quaternion.Euler(0f, 0f, rotationBoundaries.y) 
                : transform.rotation = Quaternion.Euler(0f, 0f, rotationBoundaries.x);
        }
    }
}

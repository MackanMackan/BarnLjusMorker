using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFlashlight : MonoBehaviour
{
    float angleRad;
    Vector3 lookAt;
    float angleDeg;
    void Update()
    {
        RotateToMouse();
    }
    void RotateToMouse()
    {
        lookAt = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angleRad = Mathf.Atan2(lookAt.y - transform.position.y, lookAt.x - transform.position.x);
        angleDeg = (180 / Mathf.PI) * angleRad;

        transform.rotation = Quaternion.Euler(0, 0, angleDeg);
    }
}

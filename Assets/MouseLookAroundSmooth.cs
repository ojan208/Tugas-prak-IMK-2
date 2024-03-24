using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAroundSmooth : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    float maxY = 100f;
    float minY = -100f;

    public Vector2 sensitivity = Vector2.one * 360f;

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity.x;
        rotationX += Input.GetAxis("Mouse Y") * Time.deltaTime * -1 * sensitivity.y;
        rotationX = Mathf.Clamp(rotationX, minY, maxY);
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}

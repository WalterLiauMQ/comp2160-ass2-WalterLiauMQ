using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    // Specifies car to track

    public Transform target;
    public float tempX;
    public float tempY;
    public float tempZ;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {

        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        tempX = target.transform.eulerAngles.x;
        tempY = target.transform.eulerAngles.y;
        tempZ = target.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(tempX - tempX, tempY, tempZ - tempZ);

       // transform.LookAt(target);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    // Specifies car to track
    public CarController car;
    public float tempX;
    public float tempY;
    public float tempZ;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
//        this.transform.position = car.gameObject.transform.position;
//        this.transform.rotation = car.gameObject.transform.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //        this.transform.position = car.gameObject.transform.position;
        //        this.transform.rotation = car.gameObject.transform.rotation;

        Vector3 desiredPosition = car.gameObject.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;


//        this.transform.position = car.gameObject.transform.position;

        tempX = car.gameObject.transform.eulerAngles.x;
        tempY = car.gameObject.transform.eulerAngles.y;
        tempZ = car.gameObject.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(tempX - tempX, tempY, tempZ - tempZ);

    }
}

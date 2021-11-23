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

    // Start is called before the first frame update
    void Start()
    {
//        this.transform.position = car.gameObject.transform.position;
//        this.transform.rotation = car.gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //        this.transform.position = car.gameObject.transform.position;
        //        this.transform.rotation = car.gameObject.transform.rotation;
        this.transform.position = car.gameObject.transform.position;

        tempX = car.gameObject.transform.eulerAngles.x;
        tempY = car.gameObject.transform.eulerAngles.y;
        tempZ = car.gameObject.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(tempX - tempX, tempY, tempZ - tempZ);

    }
}

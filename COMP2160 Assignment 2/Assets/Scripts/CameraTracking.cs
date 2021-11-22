using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    // Specifies car to track
    public CarController car;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = car.gameObject.transform.position;
        this.transform.rotation = car.gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
         this.transform.position = car.gameObject.transform.position;
         this.transform.rotation = car.gameObject.transform.rotation;
    }
}

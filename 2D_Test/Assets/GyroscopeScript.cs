using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GyroscopeScript : MonoBehaviour
{
    [Range(-180f,180f)]
    public float tiltAngle;
     private void FixedUpdate()
     {
        //tiltAngle = Input.gyro.rotationRate.z;
        //this.transform.rotation = Quaternion.Euler(new Vector3(0,0,tiltAngle));
        this.transform.rotation = Input.gyro.attitude;
     }
}

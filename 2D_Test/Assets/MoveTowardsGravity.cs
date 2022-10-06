using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsGravity : MonoBehaviour
{
    public Transform pivotPoint;
    public RectTransform gravityPointRect;
    private float tiltAngle;
    [Range(-180,180)]
    public float testAngle;
    private void FixedUpdate()
    {
        Input.gyro.enabled = true;
        tiltAngle = -Input.gyro.attitude.z;
        pivotPoint.transform.rotation = Quaternion.Euler(0, 0, tiltAngle * 100);
        Physics2D.gravity = new Vector2(gravityPointRect.anchoredPosition.x * 1000, gravityPointRect.anchoredPosition.y * 1000);
        //print(tiltAngle);
    }
    private Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}

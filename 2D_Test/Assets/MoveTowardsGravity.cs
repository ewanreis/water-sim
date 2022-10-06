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
        tiltAngle = Input.gyro.attitude.z;
        pivotPoint.transform.rotation = Quaternion.Euler(0, 0, testAngle);
        Physics2D.gravity = new Vector2(gravityPointRect.anchoredPosition.x * 1000, gravityPointRect.anchoredPosition.y * 1000);
    }
}

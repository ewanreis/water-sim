using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToPoint : MonoBehaviour
{
    public Transform point;
    private void FixedUpdate()
    {
        this.transform.position = point.transform.position;
    }
}

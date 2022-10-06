using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeCollider : MonoBehaviour
{
    void FixedUpdate()
    {
        this.GetComponent<BoxCollider2D>().size = this.gameObject.GetComponent<RectTransform>().sizeDelta;
    }
}

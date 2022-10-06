using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Camera cam;
    private RaycastHit2D hit;
    private Image image;
    private Color randColor;
    private void FixedUpdate()
    {
        randColor = new Vector4(Random.value,
                                Random.value, 
                                Random.value,
                                1);
    }
    public void ColorSwitch()
    {
        image = this.GetComponent<Image>();
        image.color = randColor;
    }
}

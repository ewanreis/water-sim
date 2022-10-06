using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public GameObject ball;
    private void Awake()
    {
        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        for(int i = 0; i < 100; i++)
        {
            Instantiate(ball, this.transform.position, new Quaternion(0,0,0,0), this.transform);
            yield return new WaitForSeconds(0.1f);
        }
        yield return null;
    }
}

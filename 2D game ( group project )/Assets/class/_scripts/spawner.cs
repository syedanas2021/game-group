using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ball;
    private float spawntime= 1.5f;
    private float timer = 0;
    private int height = 6;

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer>spawntime)
        {
            GameObject newball = Instantiate(ball);
            newball.transform.position = transform.position + new Vector3((Random.Range(-height, height)), 0, 0);
            timer = 0;
        }
    }
}



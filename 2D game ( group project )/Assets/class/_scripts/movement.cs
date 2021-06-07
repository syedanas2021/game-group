using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rigi;

    public float move_velocity = 10f;


    public bool ground = false;

    private void Start()
    {
        rigi = FindObjectOfType<Rigidbody2D>();
    }
    private void Update()
    {
        Moveplayer();
    }
    private void Moveplayer()
    {
        float dirx = 0;

        if (Input.GetKey(KeyCode.A))
        {
            dirx = -5f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            dirx = +5f;
        }

        Vector3 movedir = new Vector3(dirx, 0).normalized;
        transform.position += movedir * move_velocity * Time.deltaTime;
    }
}

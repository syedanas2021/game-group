using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitornot : MonoBehaviour
{
    scorehandler sh;
    private void Start()
    {
        sh = FindObjectOfType<scorehandler>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="player")
        {
            scorehandler.score++;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "ground")
        {
            scorehandler.life--;
            Destroy(this.gameObject);
        }
    }
}

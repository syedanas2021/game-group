using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitornot : MonoBehaviour
{
    scorehandler sh;
    AudioSource aud;
    private void Start()
    {
        aud = GetComponent<AudioSource>();
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
            AudioSource.PlayClipAtPoint(aud.clip,transform.position);
            Destroy(this.gameObject);
        }
    }
}

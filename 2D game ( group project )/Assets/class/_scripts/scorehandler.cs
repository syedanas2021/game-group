using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scorehandler : MonoBehaviour
{
    public static int score = 0;
    public static int life = 3;
    public static int temp = 1;

    AudioSource aud;

    public TMP_Text scoretext;
    public TMP_Text lifetext;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
        
    }
    private void Update()
    {
        if (score>=temp)
        {
            AudioSource.PlayClipAtPoint(aud.clip, transform.position);
            temp++;
        }
        scoretext.text = "score: " + score.ToString();
        lifetext.text = "Life: " + life.ToString();

    }

}

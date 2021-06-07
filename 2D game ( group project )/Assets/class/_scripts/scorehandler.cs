using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scorehandler : MonoBehaviour
{
    public static int score = 0;
    public static int life = 3;

    public TMP_Text scoretext;
    public TMP_Text lifetext;

    private void Update()
    {
        scoretext.text = "score: " + score.ToString();
        lifetext.text = "Life: " + life.ToString();
    }

}

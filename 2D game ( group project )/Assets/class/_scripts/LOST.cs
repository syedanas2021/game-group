using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOST : MonoBehaviour
{
    public GameObject lostcanvas;
    private void Update()
    {
        if(scorehandler.life==0)
        {
            Time.timeScale = 0;
            lostcanvas.SetActive(true);
            
        }
        else
        {
            lostcanvas.SetActive(false);
        }
    }
}

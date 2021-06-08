using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenuManager : MonoBehaviour
{
    public GameObject CanvasRetryandQuit;

    public GameObject CanvasPlayer;

    public void RetryButton() // play  menu
    {
        CanvasRetryandQuit.SetActive(false);
        CanvasPlayer.SetActive(true);
    }

    public void QuitButton() // setting Back Button
    {
        CanvasRetryandQuit.SetActive(true);
        CanvasPlayer.SetActive(false);
    }
}

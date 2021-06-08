using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject CanvasMenu;

    public GameObject CanvasSettings;

    public GameObject CanvasCredits;

    public GameObject Canvascontrols;

    public GameObject CanvasVolume;

    public GameObject CanvasRetryandQuit;

    public GameObject playerscene;

    private void Start()
    {
        Time.timeScale = 1;
    }


    public void SettingButton() // setting menu
    {
        CanvasMenu.SetActive(false);
        CanvasSettings.SetActive(true);
    }

    public void BackButton() // setting Back Button
    {
        CanvasMenu.SetActive(true);
        CanvasSettings.SetActive(false);
    }

    public void CreditButton() // Credit Menu
    {
        CanvasMenu.SetActive(false);
        CanvasCredits.SetActive(true);
    }
    public void CreditsBackButton() // Credit Back Button 
    {
        CanvasMenu.SetActive(true);
        CanvasCredits.SetActive(false);
    }
    public void ControlsButton() // setting Menu
    {
        CanvasSettings.SetActive(false);
        Canvascontrols.SetActive(true);
    }
    public void controlsBackButton() // Credit Back Button 
    {
        CanvasSettings.SetActive(true);
        Canvascontrols.SetActive(false);

    }
    public void VolumeButton() // setting Menu Volume button
    {
        CanvasSettings.SetActive(false);
        CanvasVolume.SetActive(true);
    }
    public void VolumeBackButton() // Credit Back Button 
    {
        CanvasSettings.SetActive(true);
        CanvasVolume.SetActive(false);
    }

    public void playbutton()
    {
        SceneManager.LoadScene("playerscene");
    }

    
}

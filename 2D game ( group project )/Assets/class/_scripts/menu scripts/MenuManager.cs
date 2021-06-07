using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public GameObject CanvasMenu;

    public GameObject CanvasSettings;

    public GameObject CanvasCredits;


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
}

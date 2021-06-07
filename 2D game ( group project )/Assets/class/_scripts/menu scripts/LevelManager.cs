using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void ChangeLevel()
    {
        Debug.Log("your Scene will be changed");

        SceneManager.LoadScene("play_scene");
    }

    public void ChangeMenuLevel()
    {
        Debug.Log("your Scene will be changed");

        SceneManager.LoadScene("main scene");
    }


}

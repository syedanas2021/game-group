using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject pausecanvas;
    
    public void ChangeLevel()
    {
        Debug.Log("your Scene will be changed");

        SceneManager.LoadScene("playerscene");
    }

    public void ChangeMenuLevel()
    {
        Debug.Log("your Scene will be changed");

        SceneManager.LoadScene("main scene");
    }

    public void RetryButton()
    {
        
        Time.timeScale = 1;
        scorehandler.score = 0;
        scorehandler.life = 3;
        spawner.timer = 0;
        scorehandler.temp = 0;
       
        SceneManager.LoadScene("playerscene");

    }
    public void quitbutton()
    {
        
        Time.timeScale = 1;
        scorehandler.score = 0;
        scorehandler.life = 3;
        scorehandler.temp =0;
        SceneManager.LoadScene("main scene");
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    //Reloads scene MainMenu when function is ran
    public void buttonReturnMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        PauseMenuController.isPaused = false;
    }



}

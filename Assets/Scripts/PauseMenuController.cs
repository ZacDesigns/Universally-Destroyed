using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{    //Variable and Game Object References
    public GameObject pauseScreen;
    public MovementController playerController;
    [HideInInspector]
    public static bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        //Checks to see if game is paused
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        //Unpauses the game
        void Resume()
        {
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        //Pauses the game
        void Pause()
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }



    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
       {
            if(isPaused)
            {
            ResumeGame();
            } 
            else
            {
            PauseGame();
            }
       } 
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    // THX BRACKEYS :3!!!

    public void LoadMenu()
    {
        Debug.Log("Loading Menu...")
    }

    public void QuitGame()
    {
        Debug.log("Quitting Game...")
    }
}

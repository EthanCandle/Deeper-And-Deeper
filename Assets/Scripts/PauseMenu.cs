using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public bool canPause = false;
    public int restartScene;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canPause)
        {
            if (GameIsPaused)
            {
                
                Resume();

            }
            else
            {
                
                Pause();
            }
        }
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        {
            Cursor.lockState = CursorLockMode.None;
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }

    public void LoadMenu()
    {
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
       // UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Restart()
    {
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        SceneManager.LoadScene(restartScene);
    }




}

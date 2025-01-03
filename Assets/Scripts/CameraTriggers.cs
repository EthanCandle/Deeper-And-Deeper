using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggers : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Roof;
    public GameObject Gameplay;
    public GameObject player;
    public PlayerAttack pa;
    public GameObject playerCamera;
    public GameObject itself;
    public GameObject gameplayUI;
    public bool start = false;
    public float waitFor = 2;
    public PauseMenu pm;
    public void TriggerOne()
    {
        Debug.Log("Trigger 1 Happened");
        MainMenu.SetActive(false);
    }


    public void TriggerTwo()
    {
        Debug.Log("Trigger 2 Happened");
        Roof.SetActive(true);
    }

    public void TriggerThree()
    {
        Debug.Log("Trigger 3 Happened");
        
        start = true;
        StartCoroutine(StartGame());

      
       
    }


    public IEnumerator StartGame()
    {
        if (start)
        {
            yield return new WaitForSeconds(waitFor);
            Cursor.lockState = CursorLockMode.Locked;
            player.transform.position = new Vector3(0, 1, 0);
            pa.isGamePlaying = true;
            pm.canPause = true;
            Gameplay.SetActive(true);
            playerCamera.SetActive(true);
            gameplayUI.SetActive(true);
            
            itself.SetActive(false);

        }
    }

}

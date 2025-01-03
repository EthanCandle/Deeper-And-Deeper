using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPlayer : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public Timer healthBar;
    public PlayerAttack pa;
    public Rigidbody rbPlayer;
    public GameObject loseScreen;
    public GameObject gameplayUI;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHeath(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(pa.isGamePlaying)
        {
            currentHealth -= 1 * Time.deltaTime;
            healthBar.SetHealth(currentHealth);

        }

       



        if (currentHealth <= 0)
        {
            pa.isGamePlaying = false;
            gameplayUI.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            rbPlayer.velocity = new Vector3(0, 0, 0);
            loseScreen.SetActive(true);
            // make lose screen here
        }





    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText, goalText;
    public float score, targetScore;
    public GameObject winScreen;
    public GameObject gameplayUI;
    public Rigidbody rbPlayer;
    public PlayerAttack pa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

        goalText.text = "Goal: " + targetScore;

        if (score >= targetScore)
        {
            rbPlayer.velocity = new Vector3(0, 0, 0);
            pa.isGamePlaying = false;
            gameplayUI.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            winScreen.SetActive(true);
            // make player win screen here
           
        }


    }
}

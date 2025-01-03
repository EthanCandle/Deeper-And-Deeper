using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class LoseScreen : MonoBehaviour
{
    public int restartScene;
    public int nextScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public  void Lose()
    {
        SceneManager.LoadScene(restartScene);

    }

    public void Won()
    {
        SceneManager.LoadScene(nextScene);
    }



}

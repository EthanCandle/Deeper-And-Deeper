using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator p_Animator;
    public bool hasSwung, hitBoxOn, hitOre;
    public bool isGamePlaying = false;
    public TimerPlayer tp;
    public float emeraldScore, rubyScore, amethistScore;
    
    // these are to parameter the attack animation for the pickaxe

    public SpawnOre so;
    public Score sc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGamePlaying)
        {
            if (Input.GetMouseButtonDown(0) && !hasSwung)
            {
                hitOre = false;
                p_Animator.SetTrigger("Swung");
            }
            if (p_Animator.GetCurrentAnimatorStateInfo(0).IsName("Idle") && hasSwung)
            {
                hasSwung = false;
                Debug.Log("Idle");
            }

            if (p_Animator.GetCurrentAnimatorStateInfo(0).IsName("Swing") && !hasSwung && !hitOre)
            {
                hasSwung = true;
                Debug.Log("SwingStart");

            }
        }
       
        // when mouse go down play animation and have parameters to prevent another use



    }

   

    private void OnTriggerStay(Collider other)
    {
        if (isGamePlaying)
        {

            if (other.gameObject.CompareTag("Emerald") && hitBoxOn)
            {
                hitOre = true;
                //  Debug.Log("Hit Ore");
                hasSwung = false;
                p_Animator.SetTrigger("HitOre");
                so.enemyCount -= 1;
                so.StartCoroutine(so.OreDropRespawn());
            
                sc.score += emeraldScore;
            }

            if (other.gameObject.CompareTag("Ruby") && hitBoxOn)
            {
                hitOre = true;
                //  Debug.Log("Hit Ore");
                hasSwung = false;
                p_Animator.SetTrigger("HitOre");
                so.enemyCount -= 1;
                so.StartCoroutine(so.OreDropRespawn());

                sc.score += rubyScore;
            }

            if (other.gameObject.CompareTag("Amethist") && hitBoxOn)
            {
                hitOre = true;
                //  Debug.Log("Hit Ore");
                hasSwung = false;
                p_Animator.SetTrigger("HitOre");
                so.enemyCount -= 1;
                so.StartCoroutine(so.OreDropRespawn());

                sc.score += amethistScore;
            }





            // if pickaxe collides with ore while the hit box is on from the animation parameters, ore is destroyed
        }
    }



}

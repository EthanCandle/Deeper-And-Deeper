using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreHitted : MonoBehaviour
{
    public OreDestroy od;
    public GameObject ore;
    public Collider m_Collider;
    public PlayerAttack pa;
    // Start is called before the first frame update
    void Start()
    {
        pa = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && pa.hitBoxOn)
        {
            m_Collider.enabled = false;
            Debug.Log("Ore should be dissapearing");
            od.shouldContinue = true;
            Destroy(ore);
            // holder should fade out when player hits it

        }



    }
}

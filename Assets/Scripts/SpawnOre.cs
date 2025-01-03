
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOre : MonoBehaviour
{
    public List<GameObject> theEnemy;
    public int xPos;
    public int zPos;
    public int xPosRandomPos;
    public int xPosRandomNeg;
    public int zPosRandomPos;
    public int zPosRandomNeg;
    public int enemyCount;
    public int enemyWant = 10;
    public float spawnWait;
    public float spawnWaitStart = 0.5f;
    // gets the x and z position that the ores should spawn in, the current amount of enemmies, how many there should be, and the time it should take for them to spawn


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    public IEnumerator EnemyDrop()
    {
        while (enemyCount < enemyWant)
        {
            xPos = Random.Range(xPosRandomNeg, xPosRandomPos);
            zPos = Random.Range(zPosRandomNeg, zPosRandomPos);
            int index = Random.Range(0, theEnemy.Count);
            Instantiate(theEnemy[index], new Vector3(xPos, 0.5f, zPos), Quaternion.Euler(0, Random.Range(0, 360), 0));
            yield return new WaitForSeconds(spawnWaitStart);
            enemyCount += 1;
            // spawns ores when ores is less than 10, change the x and z Pos to change where they spawn
            // Quaternion.identity, incase i need it again
        }
    }

    public IEnumerator OreDropRespawn()
    {
       
            xPos = Random.Range(xPosRandomNeg, xPosRandomPos);
            zPos = Random.Range(zPosRandomNeg, zPosRandomPos);
             int index = Random.Range(0, theEnemy.Count);
             Instantiate(theEnemy[index], new Vector3(xPos, 0.5f, zPos), Quaternion.Euler(0, Random.Range(0, 360), 0));
            yield return new WaitForSeconds(spawnWait);
            enemyCount += 1;
            // spawns ores when ores is less than 10, change the x and z Pos to change where they spawn
            // Quaternion.identity, incase i need it again
        
    }
}

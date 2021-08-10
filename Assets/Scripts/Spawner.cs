using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] monsters;
    public GameObject winnerChicken;
    int randomSpawnPoint, randomMonster;
    public static bool spawnAllowed;
    int enemyLimit = 20;
    int enemyCount = 0;

    [Header("Reference Holders")]
    public GameObject playerReference;

    private GameObject tempGO;
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAMonster", 0f, 1f);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    void SpawnAMonster()
    {
   
        if (enemyCount >= enemyLimit)
        {
            CancelInvoke("SpawnAMonster");
            //Buraya kazanma
            winnerChicken.SetActive(true);

            return;
        }
        
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomMonster = Random.Range(0, monsters.Length);
            tempGO = Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
            tempGO.GetComponent<Enemy>().player = playerReference;
            if(tempGO.GetComponent<Enemy>().enemyType == EnemyType.BigEnemy)
            {
                tempGO.GetComponent<Enemy>().enemyHealth = 200;
            }
            else
            {
                tempGO.GetComponent<Enemy>().enemyHealth = 100;
            }
            enemyCount++;
        }
    }
}

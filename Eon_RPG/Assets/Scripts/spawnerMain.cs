using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerMain : MonoBehaviour
{
    public GameObject enemyPrefab;
    public bool stopSpawing = false;
    public float spawnTime;
    public float spawnDelay;
    private int maxSpawner = 15;
    private int enemyCount = 0;
    
    //public Rect spawnArea;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnDelay);
    }

    private void Update()
    {
        
    }


    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
        enemyCount++;
       
        if(enemyCount == maxSpawner)
        {

            stopSpawing = true;

            if (stopSpawing)
            {

                CancelInvoke("SpawnEnemy");

            }
        }
            
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// reference used : https://www.youtube.com/watch?v=NWNH9XRtuIc
public class EnemyManager : MonoBehaviour
{
    float lastSpawnedTime = 0;
    public Transform[] mobSpawnPoints;
    public GameObject mobEnemyPrefab;
    public float spawnInterval = 10f;

    // Start is called before the first frame update
    void Start()
    {
        if (MainMenu.difficulty == "EasyBtn") spawnInterval = 15f;
        if (MainMenu.difficulty == "NormalBtn") spawnInterval = 10f;
        if (MainMenu.difficulty == "HardBtn") spawnInterval = 5f;



    }
    // Update is called once per frame
    void Update()
    {
        //every 10 seconds make it so that spawners spawn new enemy
        if (Time.realtimeSinceStartup - lastSpawnedTime >= 10f)
        {
            lastSpawnedTime = Time.realtimeSinceStartup;
            SpawnNewEnemies();

        }

    }
   

    void SpawnNewEnemy()
    {
        Instantiate(mobEnemyPrefab, mobSpawnPoints[0].transform.position, Quaternion.identity);

    }
    void SpawnNewEnemies()
    {
        //print(mobSpawnPoints.Length);
        for (int i = 0; i< mobSpawnPoints.Length-1;i++)
        {
            
            Instantiate(mobEnemyPrefab, mobSpawnPoints[i].transform.position, Quaternion.identity);

        }
    }
}

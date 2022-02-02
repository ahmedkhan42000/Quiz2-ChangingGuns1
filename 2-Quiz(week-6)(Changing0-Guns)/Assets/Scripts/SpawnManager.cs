using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Enemy;

    private float Boundry = 5;
    private int EnemyCount;
    public int WaveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        SpawnEnemyWave(WaveNumber);
    }
    void SpawnEnemyWave(int EnemiesToSpawn)
    {
      
        for (int i = 0; i < EnemiesToSpawn; i++)
        {
            spawnEnemies();
        }
    }
    public void spawnEnemies()
    {
        float BoundryX = Random.Range(-Boundry, Boundry);
        float BoundryZ = Random.Range(-Boundry, Boundry);
        Instantiate(Enemy[EnemyCount], new Vector3(BoundryX, 0, BoundryZ), Enemy[EnemyCount].transform.rotation);
    }
    
    
    // Update is called once per frame
    void Update()
    {
        EnemyCount = FindObjectsOfType<EnemyCOntroller>().Length;
        if (EnemyCount == 0)
        {
            WaveNumber++;
            SpawnEnemyWave(WaveNumber);
        }
    }
}

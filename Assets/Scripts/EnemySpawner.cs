using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] int numberOfEnemies = 5;
    List<GameObject> spawnedEnemies = new List<GameObject>();
    [SerializeField] GameObject enemyPrefab;
    List<Vector3> spawnPoints;
    System.Random rnd = new System.Random();
    public PlayerMovement player;


    public GameObject SpawnEnemy(int id){
        GameObject enemy = Instantiate(enemyPrefab, spawnPoints[rnd.Next(0, spawnPoints.Count)], Quaternion.identity);
        enemy.GetComponent<Enemy>().id = id;
        return enemy;
    }

    // Start is called before the first frame update
    void Start()
    {   
        spawnPoints = new List<Vector3>();
        spawnPoints.Add(new Vector3(-27,0,35));
        spawnPoints.Add(new Vector3(-50,0,35));
        for(int i = 0; i < numberOfEnemies; i++){
            spawnedEnemies.Add(SpawnEnemy(i));
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnManager_sc : MonoBehaviour
{   
    bool stopSpawing = false;

    [SerializeField]
    GameObject enemyPrefab;

    [SerializeField]
    GameObject EnemyContainer;

    bool stopSpawning=false;

    [SerializeField]
    IEnumerator SpawnRoutine()
    {

        while(stopSpawning==false)
        {
            Vector3 position = new Vector3(Random.Range(-9.4f, 9.4f), 7.4f, 0);
            GameObject new_enemy = Instantiate(enemyPrefab, position, Quaternion.identity);
            new_enemy.transform.parent = EnemyContainer.transform;
            yield return new WaitForSeconds(5.0f);
        }
    }
    
    public void OnPlayerDeath(){
        stopSpawning = true;
    }
    
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    
    void Update()
    {
        
    }

    
    
}
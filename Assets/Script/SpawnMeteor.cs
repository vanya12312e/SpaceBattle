using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnMeteor : MonoBehaviour
{
    public GameObject MeteorPrefab;

    private void Start()
    {
        InvokeRepeating("MeteorSpawner", 1, 3);
    }

    private void MeteorSpawner()
    {
          Vector2 spawnPos = new Vector2(Random.Range(-10f, 10f), 9f);
            Instantiate(MeteorPrefab, spawnPos, Quaternion.identity);
            
            
        
          
        
    }
    
}
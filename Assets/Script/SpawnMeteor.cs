using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnMeteor : MonoBehaviour
{
    public GameObject MeteorPrefab;
    public float RepeateRate = 3;

    private void Start()
    {
        InvokeRepeating("MeteorSpawner", 1, RepeateRate);
    }

    private void MeteorSpawner()
    {
          Vector2 spawnPos = new Vector2(Random.Range(-10f, 10f), 9f);
            Instantiate(MeteorPrefab, spawnPos, Quaternion.identity);
            RepeateRate -= 0.01f;

    }
}
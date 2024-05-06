using System;
using UnityEngine;

public class MoveMeteor : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector2.down * 3 * Time.deltaTime);
        
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("DestroyZone")) Destroy(gameObject);
    }
}

using System;
using UnityEngine;

public class MoveMeteor : MonoBehaviour
{
    private LosePanel _losePanel;
    [SerializeField] private GameObject losePanel;
    private void Update() => transform.Translate(Vector2.down * 3.5f * Time.deltaTime);
    

    private void Awake()
    {
        Time.timeScale = 1;
        losePanel.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("DestroyZone"))
        {
            Destroy(gameObject);
            losePanel.SetActive(true);
            
        }
        if(col.CompareTag("Bullet")) Destroy(gameObject);
    }

    public class LosePanel : MonoBehaviour
    {
        
    }
}

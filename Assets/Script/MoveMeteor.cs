using UnityEngine;

public class MoveMeteor : MonoBehaviour
{
    public GameObject Panel;
    private void Update() => transform.Translate(Vector2.down * 3.5f * Time.deltaTime);
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("DestroyZone"))
        {
            Destroy(gameObject);
            Panel.SetActive(true);
        }
        if(col.CompareTag("Bullet")) Destroy(gameObject);
           
    }
}

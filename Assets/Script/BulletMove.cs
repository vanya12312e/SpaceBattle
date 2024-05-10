using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector2.right * 30 * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("BulletDestroy")) Destroy(gameObject);
        if (col.CompareTag("Meteorit"))
        {
            Destroy(gameObject);
        }
    }
}

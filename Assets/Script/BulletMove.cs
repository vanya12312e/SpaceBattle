using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private GameObject particle;
    [SerializeField] private AudioClip exploision;
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
            Instantiate(particle, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(exploision, transform.position);
            
        }
    }
}

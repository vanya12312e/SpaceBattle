using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [HideInInspector] private Rigidbody2D _rigidbody2D;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(Vector2.right * 30 * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("BulletDestroy")) Destroy(gameObject);    
        if(col.CompareTag("Meteorit")) Destroy(gameObject);
    }
}

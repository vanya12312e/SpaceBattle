using UnityEngine;

[RequireComponent(typeof( Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]

public class PlayerMover : MonoBehaviour
{
 [SerializeField] private float speed;
 [HideInInspector] public Rigidbody2D Rigidbody2D;

 private void Start()
 {
  Rigidbody2D = GetComponent<Rigidbody2D>();

 }

 private void Update()
 {
   Move();

 }

 private void Move()  
 {
  var InputX = Input.GetAxis("Horizontal");
    Vector2 movement = new Vector2(speed * InputX, 0);
    Rigidbody2D.velocity = movement;
 }
}

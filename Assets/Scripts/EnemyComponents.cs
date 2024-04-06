using UnityEngine;

public class EnemyComponents : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Enemy;
    [SerializeField] private float Speed = 1f;
    private void Start()
    {
        Enemy = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Enemy.velocity = -transform.up * Speed;
        if(transform.position.y < -5.1f || transform.position.y > 10.2f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            Destroy(gameObject);
        }

    }
}

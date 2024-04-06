using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Rb;
    [SerializeField] private float Speed = 2f;
    void Start()
    {
        Rb=GetComponent<Rigidbody2D>();
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Rb.velocity = -transform.up * Speed;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Rb.velocity = -transform.up * (Speed + 1f);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Rb.velocity = -transform.up * (Speed + 2f);
        }
    }
    void Update()
    {
        if (transform.position.y > 5.1f || transform.position.y < -5.1f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("bullet"))
        {
            Destroy(gameObject);
        }

    }
}

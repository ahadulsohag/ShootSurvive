using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
public class BulletComponents : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Rb;
    [SerializeField] private float Speed = 3f;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            Rb.velocity = transform.up * Speed;
        } else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Rb.velocity = transform.up * (Speed +1.5f);
        } else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Rb.velocity = transform.up * (Speed + 2.5f);
        }

    }
    void Update()
    {
        if (transform.position.y > 5.1f || transform.position.y < -5.1f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("playerkill") || collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Coin : MonoBehaviour
{
    [SerializeField] float Speed = 4f;
    [SerializeField] Rigidbody2D Rb;
    void Start()
    {
        Rb.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Rb.velocity = -transform.up * Speed;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Rb.velocity = -transform.up * (Speed + 1f);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Rb.velocity = -transform.up * (Speed + 2f);
        }
        if (transform.position.y > 5.2f || transform.position.y < -5.2f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

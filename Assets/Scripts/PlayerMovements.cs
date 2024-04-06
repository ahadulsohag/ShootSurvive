using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Rb;
    [SerializeField] private float AxisSpeed = 10f;
    [SerializeField] private float MapLength = 5f;
    [SerializeField] private float MapWidth = 3.58f;
    void Start()
    {
        Rb.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        Vector2 Movement = new (HorizontalInput * AxisSpeed, VerticalInput * AxisSpeed);
        Vector2 NewPosition = Rb.position + Movement * Time.fixedDeltaTime;
        NewPosition.x = Mathf.Clamp(NewPosition.x, -MapLength, MapLength);
        NewPosition.y = Mathf.Clamp(NewPosition.y, -MapWidth, MapWidth);
        Rb.MovePosition(NewPosition);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("playerkill") || collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            } else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            } else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
        if (collision.CompareTag("Coin"))
        {
            GameObject[] targets = GameObject.FindGameObjectsWithTag("playerkill");
            foreach (GameObject target in targets)
            {
                Destroy(target);
            }
            GameObject[] targets1 = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject target in targets1)
            {
                Destroy(target);
            }
        }
    }
}

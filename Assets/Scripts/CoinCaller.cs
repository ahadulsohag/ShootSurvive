using UnityEngine;
using UnityEngine.SceneManagement;
public class CoinCaller : MonoBehaviour
{
    [SerializeField] Rigidbody2D Rb;
    [SerializeField] Transform[] Spikes;
    [SerializeField] float TimeBetweenSpawn = 20f;
    [SerializeField] float NextSpawn = 15f;
    private void Update()
    {
        if (Time.time > NextSpawn)
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                Spawn();
                NextSpawn = Time.time + TimeBetweenSpawn + 10f;
            } else if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                Spawn();
                NextSpawn = Time.time + TimeBetweenSpawn + 20f;
            } else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                Spawn();
                NextSpawn = Time.time + TimeBetweenSpawn + 30f;
            }

        }
    }
    void Spawn()
    {
        int random = Random.Range(0, Spikes.Length);
        Instantiate(Rb, Spikes[random].position, Quaternion.identity);
    }
}

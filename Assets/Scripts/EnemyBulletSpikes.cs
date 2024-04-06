using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBulletSpikes : MonoBehaviour
{
    [SerializeField] private Transform[] BulletSpikes;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private float IntervalSpawn = 2f;
    [SerializeField] private float TimeToSpawn = 1f;
    void Update()
    {
        if (Time.time >= TimeToSpawn)
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                Spawn();
                TimeToSpawn = Time.time + IntervalSpawn;
            }
            else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                Spawn();
                TimeToSpawn = Time.time + (IntervalSpawn- 0.3f);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                Spawn();
                TimeToSpawn = Time.time + (IntervalSpawn - 0.6f);
            }
        }
    }
    void Spawn()
    {

        Instantiate(BulletPrefab, BulletSpikes[0].position, Quaternion.identity);

    }
}

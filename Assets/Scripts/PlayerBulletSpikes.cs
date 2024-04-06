using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBulletSpikes : MonoBehaviour
{
    [SerializeField] private Transform[] BulletSpikes;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private float IntervalSpawn = 1f;
    [SerializeField] private float TimeToSpawn = 0.5f;
    void Update()
    {
        if(Time.time >= TimeToSpawn)
        {
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                Spawn();
                TimeToSpawn = Time.time + IntervalSpawn;
            }else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                Spawn();
                TimeToSpawn = Time.time + (IntervalSpawn - 0.3f);
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
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Instantiate(BulletPrefab, BulletSpikes[0].position, Quaternion.identity);
        } else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            for(int i = 1; i < BulletSpikes.Length; i++)
            {
                Instantiate(BulletPrefab, BulletSpikes[i].position, Quaternion.identity);
            }
           
        }else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            for (int i = 0; i < BulletSpikes.Length; i++)
            {
                Instantiate(BulletPrefab, BulletSpikes[i].position, Quaternion.identity);
            }

        }
    }

}

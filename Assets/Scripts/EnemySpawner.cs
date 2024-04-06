using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform[] EnemySpikes;
    [SerializeField] float nextSpawnTime = 1f;
    [SerializeField] float timeBetweenSpawn = 3f;
    [SerializeField] GameObject Enemy;
    void Update()
    {
        if(Time.time >= nextSpawnTime)
        {
            Spawn();
            nextSpawnTime = Time.time + timeBetweenSpawn;
        }
        
    }
    void Spawn()
    {
        int random = Random.Range(0, EnemySpikes.Length);
        Instantiate(Enemy, EnemySpikes[random].position, Quaternion.identity);
    }
    
}
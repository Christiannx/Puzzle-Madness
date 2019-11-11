using UnityEngine;

public class Spawner : MonoBehaviour {
    public Enemy[] enemies;
    public float spawnTime;

    void Start() {
        InvokeRepeating(nameof(Spawn), 0, spawnTime);
    }

    public void Spawn() {
        int rand = Random.Range(0, 2);
        Instantiate(enemies[rand], transform.position, Quaternion.identity);
    }
}

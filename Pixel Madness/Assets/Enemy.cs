using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Enemy : MonoBehaviour {
    public Mode mode;
    public float speed;

    void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            var playerMode = other.GetComponent<Player>().mode;
            if (playerMode != mode) {
                Destroy(gameObject);
            } else {
                var loseText = FindObjectOfType<TextMeshProUGUI>();
                loseText.color = Color.black;
                Destroy(FindObjectOfType<Spawner>());
                Invoke(nameof(Reload), 2);
            }
        }
    }
    
    public void Reload() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);            
}

using UnityEngine;

public class Player : MonoBehaviour {
    public Mode mode;
    public Sprite[] sprites;

    new SpriteRenderer renderer;

    void Start() {
        mode = Mode.outwards;
        renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = sprites[0];
    }

    void Update() {
        if (Input.GetKeyDown("a")) {
            mode = Mode.inwards;
            renderer.sprite = sprites[1];
        } else if (Input.GetKeyDown("d")) {
            mode = Mode.outwards;
            renderer.sprite = sprites[0];
        }
    }
}

public enum Mode {
    outwards, inwards
}
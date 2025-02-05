using UnityEngine;

public class Saw : MonoBehaviour {
    public float speed;
    public float moveTime;
    private bool directionRight;
    private float timer;

    void Update() {
        if (directionRight) {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        } else {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;

        if (timer > moveTime) {
            directionRight = !directionRight;
            timer = 0f;
        }
    }
}

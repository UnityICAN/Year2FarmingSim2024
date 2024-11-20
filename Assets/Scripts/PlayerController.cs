using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private float speed;

    private void Update() {
        playerRigidbody.velocity = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0f) * speed;
    }
}

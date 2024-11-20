using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private float speed;
    [SerializeField] private LayerMask interactableLayerMask;

    [SerializeField] private Seed seed; // Placeholder until we have an inventory

    private GameObject plantationUnderPlayer;

    private void Start() {
        plantationUnderPlayer = null;
    }

    private void Update() {
        // Movement
        playerRigidbody.velocity = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0f) * speed;

        // Plantation detection
        RaycastHit2D hit = Physics2D.Raycast(
            playerRigidbody.transform.position,
            Vector2.zero,
            Mathf.Infinity,
            interactableLayerMask);

        if (hit.collider != null)
            plantationUnderPlayer = hit.collider.gameObject;

        // Planting logic
        if (Input.GetButtonDown("Jump") && plantationUnderPlayer != null) {
            PlantationController plantation = plantationUnderPlayer.GetComponent<PlantationController>();
            if (!plantation.HasSeed)
                plantation.HandleSowing(seed);
        }
    }
}

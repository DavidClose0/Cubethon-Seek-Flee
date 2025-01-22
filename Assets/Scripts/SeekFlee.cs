using UnityEngine;

public class SeekFlee : MonoBehaviour {
    public Transform player;
    public Rigidbody rb;
    Vector3 direction;

    // 1 = seek, -1 = flee
    int behavior;
    public float maxSpeed = 2000f;

    // On initialization, 50/50 chance to seek or flee
    void Start() {
        if (Random.Range(0f, 1f) < .5) {
            behavior = 1;
        } else {
            behavior = -1;
        }
    }

    // Update is called once per frame
    void FixedUpdate() {
        // Only move if player is close
        if (Vector3.Distance(player.position, rb.position) < 50)
            // Direction of velocity vector depends on behavior
            direction = player.position - rb.position;
            direction.Normalize();
            rb.linearVelocity = direction * behavior * maxSpeed;

            // Face towards movement direction
            rb.rotation = Quaternion.LookRotation(direction);
            Debug.Log(player.position);
    }
}

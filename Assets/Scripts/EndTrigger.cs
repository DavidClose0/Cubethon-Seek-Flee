using UnityEngine;

public class EndTrigger : MonoBehaviour {
    void OnTriggerEnter(Collider collisionInfo) {
        if (collisionInfo.GetComponent<Collider>().tag == "Player") {
            FindFirstObjectByType<GameManager>().CompleteLevel();
        }
    }
}

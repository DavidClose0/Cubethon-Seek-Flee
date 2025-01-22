using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject completeLevelUI;

    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public void EndGame() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPoint : MonoBehaviour
{
    public int scene;
    // Example: Load the next scene when something enters the exit point
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Assuming the player has a "Player" tag
        {
            LoadNextScene();
        }
    }

    // Example: Method to load the next scene
    private void LoadNextScene()
    {
        // Change "YourNextSceneName" to the name of the scene you want to load
        SceneManager.LoadScene(scene);
    }
}
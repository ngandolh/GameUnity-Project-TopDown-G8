using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public void LoadScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
    public void CloseApplication()
    {
        Application.Quit();
    }
}

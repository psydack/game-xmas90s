using UnityEngine;
using UnityEngine.SceneManagement;


public class Utilities : MonoBehaviour
{
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
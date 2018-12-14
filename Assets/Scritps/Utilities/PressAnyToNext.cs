using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyToNext : MonoBehaviour
{

    /// <summary>
    /// Scene name reference to load (synced)
    /// </summary>
    public string sceneName;

    // Update is called once per frame
    /// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

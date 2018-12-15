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

    public float timerUntilLoad = 2f;

    // Update is called once per frame
    /// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
    {
        timerUntilLoad -= Time.deltaTime;
        if (timerUntilLoad <= 0 && Input.anyKeyDown)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

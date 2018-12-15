using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspetoShow : MonoBehaviour
{
    bool once = false;
    public List<GameObject> gosToShow = new List<GameObject>();

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        for (int i = 0; i < gosToShow.Count; i++)
        {
            gosToShow[i].SetActive(false);
        }
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (once) return;
        for (int i = 0; i < gosToShow.Count; i++)
        {
            gosToShow[i].SetActive(true);
        }
        once = true;
    }
}

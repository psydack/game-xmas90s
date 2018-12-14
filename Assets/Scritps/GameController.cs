using UnityEngine;


public class GameController : MonoBehaviour
{

    /// <summary>
    /// GameController Instance
    /// </summary>
    public static GameController instance;


    public /// <summary>
           /// Awake is called when the script instance is being loaded.
           /// </summary>
    void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            DestroyImmediate(this);
        }
    }



}
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    /// <summary>
    /// Load next Level
    /// </summary>
    /// <param name="levelName">Level name</param>
    void LoadLevel(string levelName)
    {
        PressAnyToNext.LoadLevel(levelName);
    }

    /// <summary>
    /// Used in UI when push as UnityEvents. 
    /// Make player boy
    /// </summary>
    public void SetPlayerBoy()
    {
        PlayerPrefs.SetString(PrefsVar.PLAYER_GENDER, PrefsVar.PLAYER_GENDER_BOY);
        this.LoadLevel("GameCutscene");
    }

    /// <summary>
    /// Used in UI when push as UnityEvents. 
    /// Make player girl
    /// </summary>
    public void SetPlayerGirl()
    {
        PlayerPrefs.SetString(PrefsVar.PLAYER_GENDER, PrefsVar.PLAYER_GENDER_GIRL);
        this.LoadLevel("GameCutscene");
    }
}
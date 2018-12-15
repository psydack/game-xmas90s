using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGender : MonoBehaviour
{

    public GameObject boyGO;
    public GameObject girlGO;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        // PlayerPrefs.SetString(PrefsVar.PLAYER_GENDER, PrefsVar.PLAYER_GENDER_GIRL);

        string gender = PlayerPrefs.GetString(PrefsVar.PLAYER_GENDER, PrefsVar.PLAYER_GENDER_BOY);
        if (gender == PrefsVar.PLAYER_GENDER_GIRL)
        {
            SendMessage("Setup", girlGO);
            boyGO.SetActive(false);
        }
        else
        {
            SendMessage("Setup", boyGO);
            girlGO.SetActive(false);
        }
    }
}

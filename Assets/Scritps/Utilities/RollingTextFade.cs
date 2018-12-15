using UnityEngine;
using System.Collections;


namespace TMPro.Examples
{

    public class RollingTextFade : MonoBehaviour
    {

        private TMP_Text m_TextComponent;

        void Awake()
        {
            m_TextComponent = GetComponent<TMP_Text>();
        }


        void Start()
        {
            StartCoroutine(AnimateVertexColors());
        }


        /// <summary>
        /// Method to animate vertex colors of a TMP Text object.
        /// </summary>
        /// <returns></returns>
        IEnumerator AnimateVertexColors()
        {
            // Need to force the text object to be generated so we have valid data to work with right from the start.
            m_TextComponent.ForceMeshUpdate();


            TMP_TextInfo textInfo = m_TextComponent.textInfo;

            string text = textInfo.textComponent.text;
            textInfo.textComponent.SetText("");

            for (int i = 0; i < text.Length; i++)
            {
                textInfo.textComponent.SetText(textInfo.textComponent.text + text[i]);
                yield return new WaitForSeconds(0.08f);
            }


        }
    }
}

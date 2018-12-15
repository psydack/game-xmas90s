using UnityEngine;

public class PlayerMiniGame2 : MonoBehaviour
{
    public GameObject cortaGrama;


    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        switch (GetComponent<PlayerMoveTopMouse>().side)
        {
            case PlayerMoveTopMouse.LOOKINGFOR.DOWN:
                cortaGrama.transform.localPosition = Vector2.down;
                break;
            case PlayerMoveTopMouse.LOOKINGFOR.UP:
                cortaGrama.transform.localPosition = Vector2.up;
                break;
            case PlayerMoveTopMouse.LOOKINGFOR.LEFT:
                cortaGrama.transform.localPosition = Vector2.left;
                break;
            case PlayerMoveTopMouse.LOOKINGFOR.RIGHT:
                cortaGrama.transform.localPosition = Vector2.right;
                break;
        }

        if (cortaGrama.GetComponent<CortaGrama>().counter <= 0)
        {
            PressAnyToNext.LoadLevel("MiniGame3");
        }
    }

    public void TakeDamage()
    {
        print("hitted");
    }   
}
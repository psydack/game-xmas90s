using UnityEngine;

public class PlayerMiniGame1 : MonoBehaviour
{
    public GameObject garbage;
    public GameObject lixo;
    bool catchGarbage = false;

    /// <summary>
    /// Set Garbage to true
    /// </summary>
    public void SetGarbage() { this.catchGarbage = true; garbage.SetActive(true); }


    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (garbage)
        {
            switch (GetComponent<PlayerMoveTopMouse>().side)
            {
                case PlayerMoveTopMouse.LOOKINGFOR.DOWN:
                    garbage.transform.localPosition = Vector2.down;
                    break;
                case PlayerMoveTopMouse.LOOKINGFOR.UP:
                    garbage.transform.localPosition = Vector2.up;
                    break;
                case PlayerMoveTopMouse.LOOKINGFOR.LEFT:
                    garbage.transform.localPosition = Vector2.left;
                    break;
                case PlayerMoveTopMouse.LOOKINGFOR.RIGHT:
                    garbage.transform.localPosition = Vector2.right;
                    break;
            }
        }
    }

    public void TakeDamage()
    {
        print("hitted");
        Instantiate(lixo, transform.position, Quaternion.identity);
    }
}
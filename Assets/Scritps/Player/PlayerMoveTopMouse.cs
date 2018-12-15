using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTopMouse : MonoBehaviour
{	


    /// <summary>
    /// The speed of the Player
    /// </summary>
    [SerializeField] Vector2 speed = new Vector2(5f, 2f);

    // The position you clicked
    Vector2 targetPosition = Vector2.zero;
    // That position relative to the players current position (what direction and how far did you click?)
    Vector2 relativePosition = Vector2.zero;

    /// <summary>
    /// My rigidbody
    /// </summary>
    Rigidbody2D rb2d;

    [SerializeField] Vector2 zuera;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 3 - Retrieve the mouse position
        if (Input.GetButton("Fire1"))
        {
            this.targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        // Find the relative poistion of the target based upon the current position
        // Update each frame to account for any movement
        this.relativePosition = new Vector2(
            this.targetPosition.x - this.transform.position.x,
            this.targetPosition.y - this.transform.position.y);
    }

    /// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
    {
        if (this.targetPosition == Vector2.zero) return;

        // LOOK
        Vector3 diff = this.targetPosition - (Vector2)this.transform.position;

        if (diff.magnitude < 1f) return;

        this.rb2d.MovePosition(this.rb2d.position + ((Vector2)transform.up) * this.speed * Time.fixedDeltaTime);

        diff.x += Random.Range(-zuera.x, zuera.x);
        diff.y += Random.Range(-zuera.y, zuera.y);

        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

    }

}

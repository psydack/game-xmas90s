using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTopMouse : MonoBehaviour
{

    Animator animator;

    /// <summary>
    /// The speed of the Player
    /// </summary>
    [SerializeField] Vector2 speed = new Vector2(5f, 2f);

    /// <summary>
    ///  The position you clicked
    /// </summary>
    Vector2 targetPosition = Vector2.zero;
    /// <summary>
    /// That position relative to the players current position (what direction and how far did you click?)
    /// </summary>
    Vector2 relativePosition = Vector2.zero;

    /// <summary>
    /// My rigidbody
    /// </summary>
    Rigidbody2D rb2d;

    /// <summary>
    /// Make some noise
    /// </summary>
    [SerializeField] Vector2 zuera;

    Vector3 initialScale;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.initialScale = this.transform.localScale;
    }

    void Setup(GameObject goWithAnimator)
    {
        animator = goWithAnimator.GetComponent<Animator>();
    }

    void Update()
    {
        // 3 - Retrieve the mouse position
        if (Input.GetButton("Fire1"))
        {
            this.targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    /// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
    {
        if (this.targetPosition == Vector2.zero) return;

        // LOOK
        Vector2 diff = this.targetPosition - (Vector2)this.transform.position;

        if (diff.magnitude < .1f) return;
        this.rb2d.MovePosition(this.rb2d.position + diff * this.speed * Time.fixedDeltaTime);

        // diff.x += Random.Range(-zuera.x, zuera.x);
        // diff.y += Random.Range(-zuera.y, zuera.y);

        // diff.Normalize();

        // float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        Animation(diff);

    }

    /// <summary>
    /// Make Animation
    /// </summary>
    void Animation(Vector2 diff)
    {
        float x = diff.x > 0 ? diff.x : diff.x * -1;
        float y = diff.y > 0 ? diff.y : diff.y * -1;

        if (y > x)
        {
            if (diff.y > Mathf.Epsilon) animator.SetTrigger("up");
            else if (diff.y < Mathf.Epsilon) animator.SetTrigger("down");
        }
        else
        {
            if (diff.x > Mathf.Epsilon) animator.SetTrigger("right");
            else if (diff.x < Mathf.Epsilon) animator.SetTrigger("left");
        }


    }

}

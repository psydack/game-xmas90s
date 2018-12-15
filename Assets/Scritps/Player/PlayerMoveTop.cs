using UnityEngine;

public class PlayerMoveTop : MonoBehaviour
{

    Rigidbody2D rb2D;

    /// <summary>
    /// x = rotation, y = movement speed
    /// </summary>
    [SerializeField] Vector2 speed = Vector2.one;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        this.rb2D = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {

    }


    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        float horizontal = -Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.Rotate(transform.forward * speed.x * horizontal, Space.Self);
        transform.Translate(transform.up * vertical * speed.y * Time.deltaTime, Space.World);
        // rb2D.MovePosition(rb2D.position + ((Vector2)this.transform.up * vertical * speed.y * Time.fixedDeltaTime));

        Debug.DrawRay(transform.position, transform.up, Color.red);
    }
}

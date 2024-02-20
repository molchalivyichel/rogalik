using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    void Move_player()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move_player();
    }
}

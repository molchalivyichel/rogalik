using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _speed;

    public float speed;

    void Move_player()
    {
        _rb.velocity = new Vector2(Input.GetAxis("Horizontal") * _speed, _rb.velocity.y);
    }

    void Start()
    {
        _speed = speed;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        print($"{_speed} _speed");
        print($"{speed} speed");
        Move_player();
    }
}

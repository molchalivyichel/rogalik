using System.Collections;

using UnityEngine;

public class Gun_damage : MonoBehaviour
{
    private Rigidbody2D _rb;

    private float _horizontal;

    private float _speed;

    private int _enter_damage;

    public float speed;

    public int enter_damage;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _speed = speed;
        _enter_damage = enter_damage;

        Horizontal();
    }

    void Horizontal()
    {
        if (transform.localRotation.y == 0)
        {
            _horizontal = 1;
        }
        else
        {
            _horizontal = -1;
        }
    }

    void Move_sphere()
    {
        _rb.velocity = new Vector2(_horizontal * _speed, _rb.velocity.y);
    }

    void FixedUpdate()
    {
        Move_sphere();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Damage_hp>().Attack(_enter_damage);
        
        Destroy_object();
    }

    void Destroy_object()
    {
        Destroy(gameObject);
    }




}

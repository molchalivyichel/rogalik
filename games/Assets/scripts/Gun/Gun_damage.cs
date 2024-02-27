using System.Collections;

using UnityEngine;

public class Gun_damage : MonoBehaviour
{

    private float _horizontal;

    private float _speed;

    private int _enter_damage;

    public float speed;

    public int enter_damage;

    void Start()
    {
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
        transform.position += new Vector3(_horizontal * _speed * Time.fixedDeltaTime, 0);
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

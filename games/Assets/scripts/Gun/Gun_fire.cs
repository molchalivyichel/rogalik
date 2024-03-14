using System.Collections;
using UnityEngine;

public class Gun_fire : MonoBehaviour
{
    private int _enter_damage;
    private int _extra_damage;
    private float _extra_interval_second;
    private int _extra_number;
    private GameObject _object;
    private bool _enter = false;

    public int enter_damage;
    public int extra_damage;
    public float extra_interval_second;
    public int extra_number;

    void Start()
    {
        _enter_damage = enter_damage;
        _extra_damage = extra_damage;
        _extra_interval_second = extra_interval_second;
        _extra_number = extra_number;
    }

    
    IEnumerator EnterDamage()
    {
        for (int i = 0; i < _extra_number; i++)
        {
            yield return new WaitForSeconds(_extra_interval_second);
            _object.GetComponent<Damage_hp>().Attack(_extra_damage);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy" || collision.collider.tag == "Player")
        {
            _object = collision.gameObject;
            _object.GetComponent<Damage_hp>().Attack(_enter_damage);
            _enter = true;
        }
    }

    void Update()
    {
        if (_enter)
        {
            _enter = false;
            StartCoroutine(EnterDamage());
        }
    }
}

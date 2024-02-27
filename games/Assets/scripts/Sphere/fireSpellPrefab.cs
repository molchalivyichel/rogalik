using System.Collections;

using UnityEngine;

public class fireSpellPrefab : MonoBehaviour
{
    private GameObject Enemy;

    private Rigidbody2D rb_spellPrefab;

    private int horizontal;

    public float speed;

    public int enter_damage;

    public int extra_damage;
    public float extra_interval_second;
    public int extra_number;

    void Start()
    {
        rb_spellPrefab = GetComponent<Rigidbody2D>();

        Horizontal();

    }

    void Horizontal()
    {
        if (transform.localRotation.y == 0)
        {
            horizontal = 1;
        }
        else
        {
            horizontal = -1;
        }
    }

    void Move_sphere()
    {
        rb_spellPrefab.velocity = new Vector2(horizontal * speed, rb_spellPrefab.velocity.y);
    }

    void Update()
    {
        Move_sphere();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Enemy = collision.gameObject;
            Enemy.GetComponent<Damage_hp>().Attack(enter_damage);
        }
        StartCoroutine(EnterDamage());

        Destroy_spell_prefab();
    }

    IEnumerator EnterDamage()
    {
        for (int i = 0; i < extra_number; i++)
        {
            yield return new WaitForSeconds(extra_interval_second);
            print($"Starting in IE {i}");
            Enemy.GetComponent<Damage_hp>().Attack(extra_damage);
        }
    }

    void Destroy_spell_prefab()
    {
        Destroy(gameObject);
    }




}

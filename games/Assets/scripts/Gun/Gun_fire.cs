using System.Collections;
using UnityEngine;

public class Gun_fire : MonoBehaviour
{
    private int _extra_damage;
    private float _extra_interval_second;
    private int _extra_number;

    public int extra_damage;
    public float extra_interval_second;
    public int extra_number;

    void Start()
    {
        _extra_damage = extra_damage;
        _extra_interval_second = extra_interval_second;
        _extra_number = extra_number;
    }

    
    IEnumerator EnterDamage()
    {
        for (int i = 0; i < _extra_number; i++)
        {
            yield return new WaitForSeconds(_extra_interval_second);
            //Enemy.GetComponent<Damage_hp>().Attack(_extra_damage);
        }
    }
}

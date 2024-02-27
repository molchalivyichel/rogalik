
using UnityEngine;

public class Damage_hp : MonoBehaviour
{
    public void Attack(int damage)
    {
        GetComponent<Hp_object>().new_rect_hp(damage);
    }
}


using UnityEngine;

public class Damage_hp_enemy : MonoBehaviour
{
    public void Attack(int damage)
    {
        print(gameObject);
        GetComponent<Hp_Enemy>().rect_hp -= damage;
    }
}

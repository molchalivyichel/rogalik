using UnityEngine;

public class Hp_Enemy : MonoBehaviour
{
    public int max_hp;
    public int rect_hp;
    private bool live = true;

    void Start()
    {
        rect_hp = max_hp;
    }

    void Check_hp()
    {
        if (rect_hp <= 0)
        {
            live = false;
        }
    }

    void FixedUpdate()
    {
        Check_hp();
    }
    
}

using UnityEngine;

public class Hp_object : MonoBehaviour
{
    private int _rect_hp;
    private int _max_hp;
    private bool _live = true;
    
    public int rect_hp;
    public int max_hp;
    public bool live => _live;

    void Start_rect_hp()
    {
        rect_hp = max_hp;
    }

    void Start()
    {
        Start_rect_hp();
        _rect_hp = rect_hp;
        _max_hp = max_hp;
    }

    public void new_rect_hp(int vallue)
    {
        _rect_hp += vallue;
    }

    void Check_live()
    {
        if (_rect_hp <= 0)
        {
            _live = false;
        }
    }

    void Check_hp()
    {
        if (_rect_hp > _max_hp)
        {
            _rect_hp = _max_hp;
        }
    }

    void FixedUpdate()
    {
        Check_hp();
        Check_live();
        print($"HP: {gameObject.name}|{_rect_hp}");
    }
    
}

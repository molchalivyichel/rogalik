using UnityEngine;

public class Manna_object : MonoBehaviour
{
    private int _rect_manna;
    private int _max_manna;

    public int rect_manna;
    public int max_manna;

    void Start_rect_manna()
    {
        rect_manna = max_manna;
    }

    void Start()
    {
        Start_rect_manna();
        _rect_manna = rect_manna;
        _max_manna = max_manna;
    }

    public void new_rect_manna(int vallue)
    {
        _rect_manna += vallue;
    }

    void Check_live()
    {
        if (_rect_manna <= 0)
        {
            _rect_manna = 0;
        }
    }

    void Check_hp()
    {
        if (_rect_manna > _max_manna)
        {
            _rect_manna = _max_manna;
        }
    }

    void FixedUpdate()
    {
        Check_hp();
        Check_live();
        print($"MANNA: {gameObject.name}|{_rect_manna}");
    }

}

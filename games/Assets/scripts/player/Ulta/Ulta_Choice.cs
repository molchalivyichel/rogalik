using UnityEngine;


public class Ulta_Choice: MonoBehaviour
{
    private KeyCode[] _keyCodes;
    private KeyCode[] _keys;
    private KeyCode _enter_key;
    private int _count;
    private bool _active;

    public KeyCode[] keyCodes;
    public KeyCode enter_key;

    void Start()
    {
        _keyCodes = keyCodes;
        _keys = new KeyCode[keyCodes.Length];
        _enter_key = enter_key;
        _count = 0;
        _active = false;
    }

    void Create_Active()
    {
        if (Input.anyKeyDown && _count < _keyCodes.Length)
        {
            foreach (KeyCode keyCode in _keyCodes)
            {
                if (Input.GetKeyDown(keyCode))
                {
                    _keys[_count] = keyCode;
                    _active = false;
                    _count++;
                    break; 
                }
            }
        }
        else if (_count == _keyCodes.Length)
        {
            if (Input.GetKeyDown(_enter_key))
            {
                _active = true;
                _count = 0;
            }
        }
    }

    public bool Check_Active()
    {
        return _active;
    }

    public KeyCode[] Check_Keys()
    {
        return _keys;
    }

    void Update()
    {
        Create_Active();
    }
}

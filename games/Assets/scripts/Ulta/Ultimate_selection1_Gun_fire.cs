using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class Ultimate_selection1_Gun_fire : MonoBehaviour
{

    private KeyCode[] _keyCodes_1;
    private GameObject _gun;

    public KeyCode[] keyCodes_1;
    public GameObject gun;

    void Start()
    {
        _gun = gun;
        _keyCodes_1 = keyCodes_1;
    }

    void Update()
    {
        if (gameObject.GetComponent<Ulta_Choice>().Check_Active() == true)
        {
            KeyCode[] player_keycode = gameObject.GetComponent<Ulta_Choice>().Check_Keys();
            if (player_keycode[0] == _keyCodes_1[0] &&
                player_keycode[1] == _keyCodes_1[1] &&
                player_keycode[2] == _keyCodes_1[2])
            {
                print($"Create {_gun}");
                gameObject.GetComponent<Create_bullet>().new_bullet(_gun);
            }
        }
    }
}

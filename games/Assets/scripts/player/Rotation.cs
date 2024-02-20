using UnityEngine;

public class Rotation : MonoBehaviour
{

    void Rotation_player()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void FixedUpdate()
    {
        Rotation_player();
    }
}

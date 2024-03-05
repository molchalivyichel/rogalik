using UnityEngine;


public class Rotation : MonoBehaviour
{
    void Rotation_player()
    {
        Vector3 Scale = gameObject.transform.localScale;

        if (Input.GetAxis("Horizontal") > 0)
        {
            Scale.x = -Mathf.Abs(Scale.x);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            Scale.x = Mathf.Abs(Scale.x);
        }
        gameObject.transform.localScale = Scale;
    }

    private void FixedUpdate()
    {
        Rotation_player();
    }
}

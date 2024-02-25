
using UnityEngine;

public class create_sphere : MonoBehaviour
{
    public GameObject target;
    public float distance;
    private int rotation; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Rotation();
            Instantiate(target, new Vector2(transform.position.x + distance * rotation,transform.position.y), transform.rotation);
        }
    }

    void Rotation()
    {
        if (transform.localRotation.y == 0)
        {
            rotation = 1;
        }
        else
        {
            rotation = -1;
        }
    }
}

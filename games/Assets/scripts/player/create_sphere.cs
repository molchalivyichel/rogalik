
using UnityEngine;

public class create_sphere : MonoBehaviour
{
    private GameObject _target;
    private float _distance;
    private int _rotation;

    public GameObject target;
    public float distance;

    void Start()
    {
        _target = target;
        _distance = distance;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Rotation();
            Instantiate(_target, new Vector2(transform.position.x + _distance * _rotation,transform.position.y), transform.rotation);
        }
    }

    void Rotation()
    {
        if (transform.localRotation.y == 0)
        {
            _rotation = 1;
        }
        else
        {
            _rotation = -1;
        }
    }
}

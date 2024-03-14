
using UnityEngine;

public class Create_bullet : MonoBehaviour
{
    private GameObject _bullet;
    private Transform _shotpoint;
    private float _timeGun;
    private float _starttimeGun;

    public Transform shotpoint;
    public float starttimeGun;

    void Start()
    {
        _shotpoint = shotpoint;
        _starttimeGun = starttimeGun;
    }

    public void new_bullet(GameObject new_bullet)
    {
        _bullet = new_bullet;
    }

    void Update()
    {
        if (_timeGun <= 0)
        {
            if (Input.GetKeyDown(KeyCode.F1) && _bullet != null)
            {
                transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + 270);
                Instantiate(_bullet, _shotpoint.position, transform.rotation);
                _timeGun = _starttimeGun;
            }
        }
        else
        {
            _timeGun -= Time.deltaTime;
        }
    }
}

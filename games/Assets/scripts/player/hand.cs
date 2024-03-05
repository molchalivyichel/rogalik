
using UnityEngine;



public class hand : MonoBehaviour
{
    private float _offset;
    private GameObject _parentObject;

    public float offset;
    public GameObject parentObject;
    void Start()
    {
        _offset = offset;
        _parentObject = parentObject;
    }

    void Edit_LocalScale(Vector3 LocalScale)
    {
        if (_parentObject.transform.localScale.x > 0f)
        {
            LocalScale.x = Mathf.Abs(transform.localScale.x);
            LocalScale.y = -Mathf.Abs(transform.localScale.y);
        }
        else
        {
            LocalScale.x = -Mathf.Abs(transform.localScale.x);
            LocalScale.y = Mathf.Abs(transform.localScale.y);
        }
        transform.localScale = LocalScale;
    }

    void Update()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.x, rotateZ + _offset);

        Edit_LocalScale(transform.localScale);
    }

}

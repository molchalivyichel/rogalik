
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.FilePathAttribute;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class hand : MonoBehaviour
{
    private GameObject _parentObject;
    private float _offset;
    private float _limitation;

    public GameObject parentObject;
    public float offset;
    public float limitation;

    void Start()
    {
        _parentObject = parentObject;
        _offset = offset;
        _limitation = limitation;
    }

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        Vector3 localScale = _parentObject.transform.localScale;
        Vector3 Scale = gameObject.transform.localScale;

        if (rotateZ > 90 || rotateZ < -90)
        {
            localScale.x = Mathf.Abs(localScale.x);
            Scale.x = Mathf.Abs(Scale.x);
            Scale.y = Mathf.Abs(Scale.y);
        }
        else
        {
            localScale.x = -Mathf.Abs(localScale.x);
            Scale.x = -Mathf.Abs(Scale.x);
            Scale.y = -Mathf.Abs(Scale.y);
        }

        //пиздец, а не код
        if (rotateZ < -90 + _limitation && Scale.x < 0)
        {
            print("three");
            rotateZ = -90 + _limitation;
        }
        else if (rotateZ > 90 - _limitation && Scale.x < 0)
        {
            print("thoo");
            rotateZ = 90 - _limitation;
        }
        else if (rotateZ !> 90 + _limitation && rotateZ !< 180 && Scale.x > 0)
        {
            rotateZ = 90 + _limitation;
        }
        else if (rotateZ !> -180 && rotateZ !< -90 - _limitation && Scale.x > 0)
        {
            rotateZ = -90 - _limitation;
        }



        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + _offset);
        gameObject.transform.localScale = Scale;
        _parentObject.transform.localScale = localScale;
    }

}

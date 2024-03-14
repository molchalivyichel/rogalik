
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float _speed;
    private float _lifetime;
    private float _distance;
    private LayerMask _layerMask;
    private string _name;


    public float speed;
    public float lifetime;
    public float distance;
    public LayerMask layerMask;
    public string name;
    

    void Start()
    {
        _speed = speed;
        _lifetime = lifetime;
        _distance = distance;
        _layerMask = layerMask;
        _name = name;
    }

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, _distance, _layerMask);
        if (hitInfo.collider != null)
        {
            print("soprikosnovenie");
            print(hitInfo.collider.name);
            if (hitInfo.collider.tag == "Enemy")
            {
                //Collider_edit();
            }
            Destroy_object();
        }
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }

    void Destroy_object()
    {
        Destroy(gameObject);
    }

}

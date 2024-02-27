using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _jumpheight;
    private bool _check_bool;
    private Transform _check;
    private float _check_rad;

    public float jumpheight;
    public Transform check;
    public float check_rad;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _jumpheight = jumpheight;
        _check = check;
        _check_rad = check_rad;
    }

    private void Jump_player()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _check_bool == true)
        {
            _rb.AddForce(transform.up * _jumpheight, ForceMode2D.Impulse);
        }
    }

    private void Check_Jump()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(check.position, _check_rad); //Круг проверяет на активность
        _check_bool = colliders.Length > 1;
    }

    void Update()
    {
        Check_Jump();
        Jump_player();
    }
}

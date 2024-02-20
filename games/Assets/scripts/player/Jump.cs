using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpheight;
    private bool check_bool;
    public Transform Check;
    public float Check_rad;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Jump_player()
    {
        if (Input.GetKeyDown(KeyCode.Space) && check_bool == true)
        {
            rb.AddForce(transform.up * jumpheight, ForceMode2D.Impulse);
        }
    }

    private void Check_Jump()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(Check.position, Check_rad); //Круг проверяет на активность
        check_bool = colliders.Length > 1;
    }

    void Update()
    {
        Check_Jump();
        Jump_player();
    }
}

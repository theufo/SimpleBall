using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private HealthBarController healthBarController;

    private int maxHealth = 150;
    private int currentHealth = 100;
    private Rigidbody2D rb;
    private float jumpForce = 0.7f;
    private float speed = 5f;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        healthBarController.Initialize(maxHealth, currentHealth);
    }

    void FixedUpdate()
    {
        if (currentHealth > 0)
        {
            float moveX = Input.GetAxis("Horizontal");
            if (moveX != 0)
                rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            }
        }
        else
        {
            //Destroy(gameObject);
        }
    }

    public void UpdateHealth(int damage)
    {
        currentHealth -= damage;
        healthBarController.UpdateHealth(currentHealth);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Transform groundCheckTransform;
    [SerializeField] private float maxHP;
    [SerializeField] private float startingHP;

    public float CurrentHP { get; private set; }
    public float MaxHP => maxHP;
 
    private SpriteRenderer playerSprite;
    private Rigidbody2D rb;

    private void Awake()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        if(Instance == null)
        {
            Instance = this;
        }
        CurrentHP = startingHP;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * speed * Time.deltaTime * horizontalInput;
        if (horizontalInput != 0)
        {
            playerSprite.flipX = horizontalInput < 0;
        }

        RaycastHit2D hit = Physics2D.Raycast(groundCheckTransform.position, Vector2.down, 0.05f, LayerMask.GetMask("Ground"));
        if (hit.collider != null && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
       
    }
    public void HealPlayer(float amount)
    {
        CurrentHP += amount;
    }
}

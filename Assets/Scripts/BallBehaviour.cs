using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public InputAction jump;
    bool started;
    bool gameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        started = false;
        rb.bodyType = RigidbodyType2D.Kinematic;
        
    }

    void OnEnable()
    {
        jump.Enable();
            
    }

    void OnDisable()
    {
        jump.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if(!started)
        {
            if(jump.triggered)
            {
                started = true;
                rb.bodyType = RigidbodyType2D.Dynamic;
            }
        }
        else
        {
            if(jump.triggered)
            {
                rb.linearVelocity = Vector2.zero;
                rb.AddForce( new Vector2 (0, jumpForce));
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="ScoreChecker" && !gameOver)
        {
            ScoreManager.instance.ScoreIncrement();
        }
        else
        {
            gameOver=true;
        }
    }


}

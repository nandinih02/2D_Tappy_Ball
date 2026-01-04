using Unity.VisualScripting;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    public static PipeBehaviour instance;
    public float moveSpeed;
    Rigidbody2D rb;

    void Awake()
    {
        if(instance==null)
        {
            instance=this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        MovePipes();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.gameOver)
        {
            StopPipes();
        }
        
    }
    void FixedUpdate()
    {
        
    }
    public void MovePipes()
    {
        rb.linearVelocity = new Vector2(moveSpeed, 0);
    }

    public void StopPipes()
    {
        rb.linearVelocity = Vector2.zero;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PipeDestroyer"))
        {
            Destroy(this.gameObject);
        }
    }
}

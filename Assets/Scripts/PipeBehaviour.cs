using Unity.VisualScripting;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    
    public float moveSpeed;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        MovePipes();
    }
    public void MovePipes()
    {
        rb.linearVelocity = new Vector2(moveSpeed, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PipeDestroyer"))
        {
            Destroy(this.gameObject);
        }
    }
}

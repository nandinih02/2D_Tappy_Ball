using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    
    public float moveSpeed;
    public float upDownSpeed;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        MovePipes();
        InvokeRepeating("SwitchUpDown",0.1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchUpDown()
    {
        upDownSpeed = -upDownSpeed;
        rb.linearVelocity = new Vector2(moveSpeed,upDownSpeed);
    }

    public void MovePipes()
    {
        rb.linearVelocity = new Vector2(moveSpeed, 0);
    }
}

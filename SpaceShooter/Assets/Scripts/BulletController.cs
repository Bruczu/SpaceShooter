using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;

    public float destroyValue = 6f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //transform.Translate(Vector2.up * moveSpeed);
        //rb.velocity = Vector3.up * moveSpeed;
    }

    
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        DestroyAfterLeftScreen();
    }
    void DestroyAfterLeftScreen()
    {
        if (transform.position.y > destroyValue)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.up * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyAfterLeftScreen();
    }
    void DestroyAfterLeftScreen()
    {
        if (transform.position.y > 6f)
        {
            Destroy(this.gameObject);
        }
    }
}

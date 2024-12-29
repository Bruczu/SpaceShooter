using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{

    public float speed = 5f;

    public Transform playerTransform;

    public Rigidbody2D rb;

    public float destroyValue = -6f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        rb.velocity = (playerTransform.position - transform.position).normalized * speed;
    }

    //Update is called once per frame
    /*void Update()
    {
        DestroyAfterLeftScreen();
    }
    void DestroyAfterLeftScreen()
    {
        if (transform.position.y < destroyValue)
        {
            Destroy(gameObject);
        }
    }
    */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

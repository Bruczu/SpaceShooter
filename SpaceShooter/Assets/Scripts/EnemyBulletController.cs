using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{

    public float speed = 5f;
    public Transform playerTransform;
    public Rigidbody2D rb;
    private Vector3 direction;
    public static PlayerController playerController;
    public GameObject bulletExplosionEffect;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        //rb.velocity = (playerTransform.position - transform.position).normalized * speed;
        direction = (playerTransform.position - transform.position).normalized;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if ((transform.position.y < -6) || (transform.position.x < -10) || (transform.position.x > 10))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.playerController.HittedByBullet();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(bulletExplosionEffect, transform.position, Quaternion.identity);
            playerController.points = playerController.points + 10;
            Destroy(gameObject);
        }
    }
}

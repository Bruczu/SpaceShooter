using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1f;

    public static PlayerController playerController;

    public Transform playertransform;

    public float fireRate = 0.5f;
    private float timeSinceLastAction = 0f;

    public GameObject bulletPrefab;
    public Transform enemyGunEnd;

    //public GameObject explosionEffectPrefab;

    void Start()
    {
        //transform.Translate(Vector2.down * speed * Time.deltaTime);
        GameObject playerGameObject = GameObject.Find("Player");
        playertransform = playerGameObject.transform;


    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y > -2)
        {
            Shoot();
        }

        if (transform.position.y < -6f)
        {
            GameManager.playerController.HittedByBullet();
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            //Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);
            playerController.points = playerController.points + 100;
            Destroy(gameObject); 
        }

        if(collision.gameObject.tag == "Player")
        {
            GameManager.playerController.HittedByBullet();
            Destroy(gameObject);
        }
    }
    void Shoot()
    {
        timeSinceLastAction += Time.deltaTime;

        if (timeSinceLastAction >= fireRate)
        {
            Instantiate(bulletPrefab, enemyGunEnd.position, Quaternion.identity);
            timeSinceLastAction = 0;
        }
    }
}

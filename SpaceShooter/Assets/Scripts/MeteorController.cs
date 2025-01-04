using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{

    public float speed = 0.6f;

    public static PlayerController playerController;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
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
            playerController.points = playerController.points + 50;
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "Player")
        {
            GameManager.playerController.HittedByBullet();
            Destroy(gameObject);
        }
    }
}

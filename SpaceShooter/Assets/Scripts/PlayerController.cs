using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int hp = 10;

    public float moveSpeed = 2f;

    public Transform minXvalue;
    public Transform maxXvalue;

    public GameObject bulletPrefab;
    public Transform gunEndPosition;

    public float fireRate = 0.2f;
    private float timeSinceLastAction = 0f;
    void Start()
    {
        GameManager.playerController = this;
    }


    void Update()
    {
        PlayerMovement();

        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }

        if (hp <= 0)
        {
            Debug.Log("Player nie ¿yje");
        }
    }

    void PlayerMovement()
    {
        float horizontalImputValue = Input.GetAxis("Horizontal");
        Vector2 movementVector = new Vector2(horizontalImputValue, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movementVector);

        if (transform.position.x > maxXvalue.position.x)
        {
            transform.position = new Vector2(maxXvalue.position.x, transform.position.y);
        }

        if (transform.position.x < minXvalue.position.x)
        {
            transform.position = new Vector2(minXvalue.position.x, transform.position.y);
        }
    }
    void Shoot()
    {
        timeSinceLastAction += Time.deltaTime;

        if (timeSinceLastAction >= fireRate)
        {
            Instantiate(bulletPrefab, gunEndPosition.position, Quaternion.identity);
            Debug.Log(gunEndPosition.position);
            timeSinceLastAction = 0f;
        }
    }
    public void HittedByBullet()
    {
        hp -= 1;
        Debug.Log("Zosta³eœ trafiony. HP: "+ hp);
    }
}

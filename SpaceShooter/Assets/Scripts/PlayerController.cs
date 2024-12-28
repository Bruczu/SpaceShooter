using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;

    public Transform minXvalue;
    public Transform maxXvalue;

    public GameObject bulletPrefab;
    public Transform gunEndPosition;
    void Start()
    {
        
    }

    
    void Update()
    {
        PlayerMovement();

        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    void PlayerMovement()
    {
        float horizontalImputValue = Input.GetAxis("Horizontal");
        Vector2 movementVector = new Vector2 (horizontalImputValue, 0) * moveSpeed * Time.deltaTime;
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
        Instantiate(bulletPrefab, gunEndPosition.position, Quaternion.identity);
    }
}

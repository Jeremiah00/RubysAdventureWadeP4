using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody2D;
    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Launch(Vector2 direction, float force)
    {
        rigidbody2D.AddForce(direction * force);
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Projectile Collision with " + other.gameObject);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Create GameObject1 that falls under gravity.  It will pass through
// Example2 and cause a collision.  GameObject1 is moved back to
// the start position and it will again start to fall under gravity.

public class Example1 : MonoBehaviour
{
    void Awake()
    {
        SpriteRenderer sr;
        sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        sr.color = new Color(0.9f, 0.9f, 0.1f, 1.0f);

        BoxCollider2D bc;
        bc = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
        bc.size = new Vector2(1.0f, 1.0f);

        Rigidbody2D rb;
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.gravityScale = 1.0f;

        // A square in the Resources folder is used.
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("square");

        // GameObject1 starts 3 units in the Up direction.
        gameObject.transform.position = new Vector3(0.0f, 3.0f, 0.0f);
        gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1.0f);
    }

    private float timer = 0.0f;
    private bool restart = false;

    void FixedUpdate()
    {
        if (restart == true)
        {
            timer = timer + Time.deltaTime;
            if (timer > 0.25f)
            {
                gameObject.transform.position = new Vector3(0.0f, 3.0f, 0.0f);
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 0.0f);
                restart = false;
            }
        }
    }

    // called when this GameObject collides with GameObject2.
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("GameObject1 collided with " + col.name);
        restart = true;
        timer = 0.0f;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Rigidbody2D rb;
    public float gameSpeed = 15f;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 Move = new Vector2(-gameSpeed * Time.deltaTime, 0);

        rb.MovePosition(rb.position + Move);
        if (rb.position.x < -20)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public GameObject player;
    public float playerSpeed = 10;
    public Rigidbody2D rb;
	// Update is called once per frame
    void Start()
    {
        player = gameObject;
        rb = player.GetComponent<Rigidbody2D>();
    }
	void FixedUpdate () {
        Vector2 Move = new Vector2(0, playerSpeed * Time.deltaTime);
        Touch[] x = Input.touches;
        foreach(var touch in x)
        {
            if(touch.phase == TouchPhase.Began){

                rb.MovePosition(rb.position + Move);
                
            }
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TapController : MonoBehaviour {

    public float tapForce = 10;
    public float tiltSmooth = 5;
    public Vector3 startPos;

    Rigidbody2D rigidbody;
 
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
        }
	}
}

void OnTriggerEnter2D(Collider2D col)
{
    if(col.gameObject.tag == "ScoreZone")
    {
        // ++ score
    }

    if(col.gameObject.tag == "DeadZone")
    {
        // kill the bird
    }
}
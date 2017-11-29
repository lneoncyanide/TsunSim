using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Touch[] x = Input.touches;
        Debug.Log(x + "!");
        if(x.GetLength(0) >= 1)
        {
            Debug.Log("Dope");
        }
	}
}

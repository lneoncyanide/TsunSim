using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatureManager : MonoBehaviour {

	private GameObject[] characterList;


	// Use this for initialization
	void Start () {
		characterList = new GameObject[transform.childCount];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
	
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatureManager : MonoBehaviour {

	private GameObject[] characterList;


	// Use this for initialization
	void Start () {
		characterList = new GameObject[transform.childCount];

		for(int i = 0; i < transform.childCount; i++)
		{
			characterList [i] = transform.GetChild (i).gameObject;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
	
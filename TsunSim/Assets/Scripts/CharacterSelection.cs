using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour 
{
	private GameObject[] characterList;
	private int index;

	private void Start ()
	{
		index = PlayerPrefs.GetInt ("CharacterSelected");

		characterList = new GameObject[transform.childCount];

		// Fill the array with our models
		for (int i = 0; i < transform.childCount; i++)
			characterList [i] = transform.GetChild (i).gameObject;

		// We toggle off their renderer
		foreach (GameObject go in characterList)
			go.SetActive (false);

		// We toggle on the first index
		if (characterList [0])
			characterList [0].SetActive (true);
	}

	public void ToggleLeft ()

	{
		//Toggle off the current model
		characterList[index].SetActive(false);

		index--;//index -=1; index = index - 1;
		if (index < 0)
			index = characterList.Length - 1;

		//Toggle on the new model
		characterList[index].SetActive(true);
	}

	public void ToggleRight()
	{
		//Toggle off current model
		characterList[index].SetActive(false);

		index++;
		if (index == characterList.Length)
			index = 0;

		//Toggle on new model
		characterList[index].SetActive(true);
	}

	public void ConfirmButton()
	{
		PlayerPrefs.SetInt("CharacterSelected", index);
		SceneManager.LoadScene("Main");
	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseHover : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().color = Color.black;


    }
    private void OnMouseEnter()
    {
        GetComponent<Text>().color = Color.blue;
    }
    private void OnMouseExit()
    {
        GetComponent<Text>().color = Color.black;
    }
}
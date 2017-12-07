using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class main_menu : MonoBehaviour {


    public void Select_scene (string name)
    {
        SceneManager.LoadScene(name);
    }
}

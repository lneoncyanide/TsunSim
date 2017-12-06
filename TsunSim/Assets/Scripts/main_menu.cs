using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Main_menu : MonoBehaviour {
    public void Scene_selection (string name)
    {
        SceneManager.LoadScene(name);
    }
}

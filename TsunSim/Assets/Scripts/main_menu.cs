using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class main_menu : MonoBehaviour {
    public void Load_scene_name (string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

}

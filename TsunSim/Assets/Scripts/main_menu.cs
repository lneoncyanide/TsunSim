using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class main_menu : MonoBehaviour {
    public void NewGameBtn (string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

}

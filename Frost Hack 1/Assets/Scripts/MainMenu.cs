using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

    public void LoadScene(string Scene)
        {
            SceneManager.LoadScene(Scene);
        }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}

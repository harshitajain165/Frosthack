using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class link : MonoBehaviour
{
    //github and linkedin link

    public void github_anshul()
    {
        Application.OpenURL("https://github.com/coder1712");
    }
    public void linkedin_anshul()
    {
        Application.OpenURL("https://www.linkedin.com/in/anshul-rana-35470b206/");
    }
    public void github_anurag()
    {
        Application.OpenURL("https://github.com/triipaathii");
    }
    public void linkedin_anurag()
    {
        Application.OpenURL("https://www.linkedin.com/in/anurag-tripathi-7422291b4/");
    }
    public void github_harshita()
    {
        Application.OpenURL("https://github.com/harshitajain165");
    }
    public void linkedin_harshita()
    {
        Application.OpenURL("http://www.linkedin.com/in/harshita-jain-bb5035203");
    }

    //to load scene or for back button

    public void LoadScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }

}

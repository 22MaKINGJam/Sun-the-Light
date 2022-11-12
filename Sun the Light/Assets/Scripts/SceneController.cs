using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene("Home");
    }
    
    public void GoStartAnimation()
    {
        SceneManager.LoadScene("StartAnimation");
    }

    public void GoMethod()
    {
        SceneManager.LoadScene("Method");
    }

    public void GoMainGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void GoEnding()
    {
        SceneManager.LoadScene("EndingAnimation");
    }
}

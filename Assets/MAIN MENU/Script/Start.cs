using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void playgame()
    {//NAMA MAP YG MAU DI TUJU
        SceneManager.LoadScene("Map tutor");
    }
    public void setting()
    {
        SceneManager.LoadScene("Seting");
    }
    public void quitgame()
    {
        Application.Quit();
    }
    public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject PausedMenu;
    public static bool IsPaused;
    // Start is called before the first frame update
    void Start()
    {
        PausedMenu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                resumeGame();
            }
            else
            {
                pausedGame();
            }

        }
    }
    public void pausedGame()
    {
        PausedMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void resumeGame()
    {
        PausedMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

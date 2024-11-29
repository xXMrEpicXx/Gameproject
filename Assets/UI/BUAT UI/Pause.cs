using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pausedMenu;
    public bool IsPaused;
    // Start is called before the first frame update
    void Start() => pausedMenu.SetActive(false);

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
        pausedMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void resumeGame()
    {
        pausedMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

}

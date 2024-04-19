using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject MenuPause;
    private static bool gamePaused = false;

    public void Pause()
    {
        gamePaused = true;
        Time.timeScale = 0;
        MenuPause.SetActive(true);
    }

    public void Resume()
    {
        gamePaused = false;
        Time.timeScale = 1;
        MenuPause.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}

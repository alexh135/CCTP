using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuCanvas : MonoBehaviour
{
    public Canvas pauseMenu;
    public SkillTreeHandler skillTreeHandler;

    void Awake()
    {
        pauseMenu.enabled = false;
        skillTreeHandler.inMenu = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.enabled = true;
            skillTreeHandler.inMenu = true;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ReturnToLevelSelect()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelect");
    }

    public void ClosePauseMenu()
    {
        pauseMenu.enabled = false;
        skillTreeHandler.inMenu = false;
    }
}

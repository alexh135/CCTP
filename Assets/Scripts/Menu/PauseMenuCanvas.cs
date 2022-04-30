using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuCanvas : MonoBehaviour
{
    //reference to the pause menu canvas
    public Canvas pauseMenu;
    // reference to script where the number of skill points is tracked
    public SkillTreeHandler skillTreeHandler;

    void Awake()
    {
        // pause menu hidden on start
        pauseMenu.enabled = false;
        // player not in menu
        skillTreeHandler.inMenu = false;
    }

    void Update()
    {
        // open pause menu when escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // enable pause menu canvas
            pauseMenu.enabled = true;
            // player now in menu
            skillTreeHandler.inMenu = true;
        }
    }

    // function for exiting the program based upon button click
    public void Exit()
    {
        Application.Quit();
    }

    // function for returning to the level select screen via button click
    public void ReturnToLevelSelect()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelect");
    }

    // function for closing pause menu based upon button click
    public void ClosePauseMenu()
    {
        // disable pause menu canvas
        pauseMenu.enabled = false;
        // player no longer in menu
        skillTreeHandler.inMenu = false;
    }
}

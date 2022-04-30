using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTreeHandler : MonoBehaviour
{
    public Behaviour SkillTreeCanvas;

    // refernce to public bool variable
    public bool inMenu = false;

    void Start()
    {
        SkillTreeCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // is player presses tab key
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // enable skill tree canvas
            SkillTreeCanvas.enabled = true;
            // player is in the menus
            inMenu = true;                                                                                                                                                                                                  
        }
    }

    // functionm for closing the menu on button click
    public void CloseMenu()
    {
        // disable skill tree canvas
        SkillTreeCanvas.enabled = false;
        // player not in menu
        inMenu = false;
    }
}

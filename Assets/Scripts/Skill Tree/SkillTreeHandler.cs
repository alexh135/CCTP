using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTreeHandler : MonoBehaviour
{
    public Behaviour SkillTreeCanvas;
    public bool inMenu = false;

    void Start()
    {
        SkillTreeCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SkillTreeCanvas.enabled = true;
            inMenu = true;                                                                                                                                                                                                  
        }
    }

    public void CloseMenu()
    {
        SkillTreeCanvas.enabled = false;
        inMenu = false;
    }
}

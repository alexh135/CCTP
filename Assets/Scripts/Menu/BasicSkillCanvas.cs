using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicSkillCanvas : MonoBehaviour
{
    public Canvas basicSkills;

    void Awake()
    {
        basicSkills.enabled = false;
    }

    //Function for opening up the basic skills menu which is attached to a buttons on click event
    public void OpenBasicSkills()
    {
        basicSkills.enabled = true;
    }

    //Function for closing the basic skills menu which is attached to a buttons on click event
    public void CloseBasicSkills()
    {
        basicSkills.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

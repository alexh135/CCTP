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

    public void OpenBasicSkills()
    {
        basicSkills.enabled = true;
    }

    public void CloseBasicSkills()
    {
        basicSkills.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

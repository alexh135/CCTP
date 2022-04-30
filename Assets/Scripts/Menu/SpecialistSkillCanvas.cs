using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialistSkillCanvas : MonoBehaviour
{
    // reference to speacialist skill canvas
    public Canvas specialistSkills;

    void Awake()
    {
        // canvas hidden on start
        specialistSkills.enabled = false;
    }

    // function for opening skills page based upon button click
    public void OpenSpecialistSkills()
    {
        // canvas enabled
        specialistSkills.enabled = true;
    }

    // function for closing canvas
    public void CloseSpecialistSkills()
    {
        // canvas disabled
        specialistSkills.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialistSkillCanvas : MonoBehaviour
{
    public Canvas specialistSkills;

    void Awake()
    {
        specialistSkills.enabled = false;
    }

    public void OpenSpecialistSkills()
    {
        specialistSkills.enabled = true;
    }

    public void CloseSpecialistSkills()
    {
        specialistSkills.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

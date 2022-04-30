using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPointHandler : MonoBehaviour
{
    // public integer variable 
    public int skillPoints = 0;

    // public text variable
    public Text skillPointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set text variable to the skill point integer value
        skillPointText.text = skillPoints.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPointHandler : MonoBehaviour
{
    public int skillPoints = 0;
    public Text skillPointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skillPointText.text = skillPoints.ToString();
    }
}

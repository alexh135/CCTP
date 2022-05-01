using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        // if player presses the Q key
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // load the skill tree menu
            UnityEngine.SceneManagement.SceneManager.LoadScene("SkillTree");
        }
    }
}

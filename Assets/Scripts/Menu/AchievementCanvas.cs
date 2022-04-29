using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementCanvas : MonoBehaviour
{
    public Canvas achievementMenu;

    void Awake()
    {
        achievementMenu.enabled = false;
    }

    public void OpenAchievements()
    {
        achievementMenu.enabled = true;
    }

    public void CloseAchievements()
    {
        achievementMenu.enabled = false;
    }

}

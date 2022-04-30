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

    //Function for opening up the achievement window as AchievementCanvas on click event attached to a button
    public void OpenAchievements()
    {
        achievementMenu.enabled = true;
    }

    //Function for closing the achievement window as AchievementCanvas on click event attached to a button
    public void CloseAchievements()
    {
        achievementMenu.enabled = false;
    }

}

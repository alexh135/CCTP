using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTreeController : MonoBehaviour
{
    // references to other script
    private LevelSelect _lvl1;
    private LevelSelect _lvl2;
    private LevelSelect _lvl3;

    public void Start()
    {
        // find corressponding component on spcified game object
        _lvl1 = GameObject.Find("LevelSelectController").GetComponent<LevelSelect>();
        _lvl2 = GameObject.Find("LevelSelectController").GetComponent<LevelSelect>();
        _lvl3 = GameObject.Find("LevelSelectController").GetComponent<LevelSelect>();
    }

    public void ReturnToGame()
    {
        StartCoroutine(buttonTimer());
    }

    IEnumerator buttonTimer()
    {
        yield return new WaitForSeconds(0.3f);
        if (_lvl1.Lvl1 == true)
        {
            // load level 1 scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        }
        if (_lvl2.Lvl2 == true)
        {
            // load level 2 scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        }
        if (_lvl3.Lvl3 == true)
        {
            // load level 3 scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    // Bools used to differenciate the different levels for each character
    public bool Lvl1;
    public bool Lvl2;
    public bool Lvl3;
    public bool Lvl4;
    public GameObject LevelSelectController;

    public void Start()
    {
        Lvl1 = false;
        Lvl2 = false;
        Lvl3 = false;
        Lvl4 = false;
    }

    // Function for opening up level one
    public void Level1()
    {
        StartCoroutine(buttonTimer1());
        Lvl1 = true;
        // Do not destroy so that script can be referenced in level
        DontDestroyOnLoad(LevelSelectController);
    }

    // Function for opening up level two 
    public void Level2()
    {
        StartCoroutine(buttonTimer2());
        Lvl2 = true;
        // Do not destroy so that script can be referenced in level
        DontDestroyOnLoad(LevelSelectController);
    }

    // Function for oopening up level three
    public void Level3()
    {
        StartCoroutine(buttonTimer3());
        Lvl3 = true;
        // Do not destroy so that script can be referenced in level
        DontDestroyOnLoad(LevelSelectController);
    }

    // Functio  for opening up level four
    public void Level4()
    {
        StartCoroutine(buttonTimer5());
        Lvl4 = true;
        // Do not destroy so that script can be referenced in level
        DontDestroyOnLoad(LevelSelectController);
    }

    // Function that returns the player to the main menu screen
    public void ReturnToMenu()
    {
        StartCoroutine(buttonTimer4());
    }

    // Coroutine used so that a button click sound can be played before the selected level is displayed
    IEnumerator buttonTimer1()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("WarriorLevel 1");
    }

    // Coroutine used so that a button click sound can be played before the selected level is displayed
    IEnumerator buttonTimer2()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("BruteLevel");
    }

    // Coroutine used so that a button click sound can be played before the selected level is displayed
    IEnumerator buttonTimer3()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("KarateLevel 1");
    }

    // Coroutine used so that a button click sound can be played before the selected level is displayed
    IEnumerator buttonTimer4()
    {
        yield return new WaitForSeconds(0.3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    // Coroutine used so that a button click sound can be played before the selected level is displayed
    IEnumerator buttonTimer5()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("SorceressLevel");
    }
}

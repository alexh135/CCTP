using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public bool Lvl1;
    public bool Lvl2;
    public bool Lvl3;
    public bool Lvl4;
    public GameObject LevelSelectController;

    public RawImage warrior;
    public RawImage brute;
    public RawImage karate;
    public RawImage sorceror;

    public void Start()
    {
        Lvl1 = false;
        Lvl2 = false;
        Lvl3 = false;
        Lvl4 = false;
        warrior.enabled = false;
        brute.enabled = false;
        karate.enabled = false;
        sorceror.enabled = false;
    }

    public void Level1()
    {
        StartCoroutine(buttonTimer1());
        Lvl1 = true;
        warrior.enabled = true;
        DontDestroyOnLoad(LevelSelectController);
    }
    public void Level2()
    {
        StartCoroutine(buttonTimer2());
        Lvl2 = true;
        brute.enabled = true;
        DontDestroyOnLoad(LevelSelectController);
    }
    public void Level3()
    {
        StartCoroutine(buttonTimer3());
        Lvl3 = true;
        karate.enabled = true;
        DontDestroyOnLoad(LevelSelectController);
    }
    public void Level4()
    {
        StartCoroutine(buttonTimer5());
        Lvl4 = true;
        sorceror.enabled = true;
        DontDestroyOnLoad(LevelSelectController);
    }
    public void ReturnToMenu()
    {
        StartCoroutine(buttonTimer4());
    }
    IEnumerator buttonTimer1()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("WarriorLevel 1");
    }
    IEnumerator buttonTimer2()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("BruteLevel");
    }
    IEnumerator buttonTimer3()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("KarateLevel 1");
    }
    IEnumerator buttonTimer4()
    {
        yield return new WaitForSeconds(0.3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
    IEnumerator buttonTimer5()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("SorceressLevel");
    }
}

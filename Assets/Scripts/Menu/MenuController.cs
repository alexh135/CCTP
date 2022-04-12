using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public void CharacterSelect()
    {
        StartCoroutine(buttonTimer());
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator buttonTimer()
    {
       yield return new WaitForSeconds(0.3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelect");
    }
}

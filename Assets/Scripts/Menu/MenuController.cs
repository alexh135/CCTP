using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Function for the loading of the chaacter selection screen based upon button click
    public void CharacterSelect()
    {
        StartCoroutine(buttonTimer());
    }

    // Function for exiting the program when button is clicked
    public void Quit()
    {
        Application.Quit();
    }

    // Coroutine for loading level/ character select screen
    IEnumerator buttonTimer()
    {
        // wait 0.3 seconds before loading the next screen
       yield return new WaitForSeconds(0.3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelect");
    }
}

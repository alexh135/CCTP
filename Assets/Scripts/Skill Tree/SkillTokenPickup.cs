using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTokenPickup : MonoBehaviour
{
    // reference to public game object
    public GameObject token;

    // reference to other script
    public SkillPointHandler pointHandler;

    // public reference to bool variable
    public bool inTrigger;

    public void Start()
    {
        inTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // if player enter skill token collider
        if(other.tag == "Player")
        {
            // destroy token
            Destroy(token);
            // add 1 skill point
            pointHandler.skillPoints++;
        }
    }
}

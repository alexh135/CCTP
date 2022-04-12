using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTokenPickup : MonoBehaviour
{
    public GameObject token;
    public SkillPointHandler pointHandler;
    public bool inTrigger;

    public void Start()
    {
        inTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(token);
            pointHandler.skillPoints++;
        }
    }
}

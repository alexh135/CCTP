using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    // reference to the broken target game object
    public GameObject brokenTarget;
    // public bools
    public bool targetBroken;
    public bool inTrigger;
    // reference to another script
    public SkillPointHandler pointHandler;

    public void Awake()
    {
        inTrigger = false;
    }

    void Update()
    {
        // if player is inside the collider for the target
        if (inTrigger)
        {
            // if player left clicks
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Break Target");
                targetBroken = true;
                Vector3 oldPos = transform.position;
                // Replace current target with broken target
                Instantiate(brokenTarget, oldPos, Quaternion.identity);
                // destroy current target
                Destroy(gameObject);
                // add 1 skill point
                pointHandler.skillPoints++;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inTrigger = true;
        }
    }

}

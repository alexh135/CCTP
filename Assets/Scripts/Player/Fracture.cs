using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    public GameObject brokenTarget;
    public bool targetBroken;
    public bool inTrigger;
    public SkillPointHandler pointHandler;

    public void Awake()
    {
        inTrigger = false;
    }

    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Break Target");
                targetBroken = true;
                Vector3 oldPos = transform.position;
                Instantiate(brokenTarget, oldPos, Quaternion.identity);
                Destroy(gameObject);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplorerRegions : MonoBehaviour
{
    public GameObject[] regions;

    public int regionsExplored;

    // Start is called before the first frame update
    void Start()
    {
        regionsExplored = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        foreach (GameObject region in regions)
        {
            if (collider.tag == "Player")
            {
                regionsExplored = regionsExplored + 1;
            }
        }
    }
}

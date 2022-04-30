using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FOVSlider : MonoBehaviour
{
    // reference to players camera
    public Camera playerCam;

    // reference to UI slider
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set the player cameras field of view to the value of the slider
        playerCam.fieldOfView = slider.value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSenseSlider : MonoBehaviour
{
    // reference to another script
    public CameraLook cameraLook;

    // reference to UI sliders
    public Slider xSlider;
    public Slider ySlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set the variables in the camera look script to the value of the sliders
        cameraLook.mouseSensitivityX = xSlider.value;
        cameraLook.mouseSensitivityY = ySlider.value;
    }
}

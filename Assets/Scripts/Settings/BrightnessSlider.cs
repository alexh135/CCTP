using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessSlider : MonoBehaviour
{
    // reference to UI slider
    public Slider slider;

    // reference to directional light in scene
    public Light gameLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set the lights intensity (brightness) to the sliders value
        gameLight.intensity = slider.value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSenseSlider : MonoBehaviour
{
    public CameraLook cameraLook;
    public Slider xSlider;
    public Slider ySlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraLook.mouseSensitivityX = xSlider.value;
        cameraLook.mouseSensitivityY = ySlider.value;
    }
}

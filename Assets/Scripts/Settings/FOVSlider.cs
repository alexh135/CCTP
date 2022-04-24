using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FOVSlider : MonoBehaviour
{
    public Camera playerCam;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerCam.fieldOfView = slider.value;
    }
}

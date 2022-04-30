using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SorceressGUI : MonoBehaviour
{
    // reference to scripts
    public SorceressClass sorceress;

    // referenes to text variables
    public Text health;
    public Text strength;
    public Text speed;
    public Text intellect;
    public Text stamina;

    // Update is called once per frame
    void Update()
    {
        // set text values to corresponding stat values
        health.text = sorceress.Health.ToString();
        stamina.text = sorceress.Stamina.ToString();
        speed.text = sorceress.Speed.ToString();
        strength.text = sorceress.Strength.ToString();
        intellect.text = sorceress.Intellect.ToString();
    }
}

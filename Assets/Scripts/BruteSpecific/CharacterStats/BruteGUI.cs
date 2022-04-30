using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BruteGUI : MonoBehaviour
{
    // reference to scripts
    public BruteClass brute;

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
        health.text = brute.Health.ToString();
        stamina.text = brute.Stamina.ToString();
        speed.text = brute.Speed.ToString();
        strength.text = brute.Strength.ToString();
        intellect.text = brute.Intellect.ToString();
    }
}

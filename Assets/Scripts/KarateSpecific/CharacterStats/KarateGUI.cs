using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarateGUI : MonoBehaviour
{
    // reference to scripts
    public KarateClass karate;

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
        health.text = karate.Health.ToString();
        stamina.text = karate.Stamina.ToString();
        speed.text = karate.Speed.ToString();
        strength.text = karate.Strength.ToString();
        intellect.text = karate.Intellect.ToString();
    }
}

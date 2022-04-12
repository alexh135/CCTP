using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarriorGUI : MonoBehaviour
{
    public WarriorClass warrior;
    public Text health;
    public Text strength;
    public Text speed;
    public Text intellect;
    public Text stamina;

    // Update is called once per frame
    void Update()
    {
        health.text = warrior.Health.ToString();
        stamina.text = warrior.Stamina.ToString();
        speed.text = warrior.Speed.ToString();
        strength.text = warrior.Strength.ToString();
        intellect.text = warrior.Intellect.ToString();
    }
}

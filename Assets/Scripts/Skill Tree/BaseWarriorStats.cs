using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseWarriorStats : MonoBehaviour
{
    //Stats
    private int stamina = 0;
    private int health = 0;
    private int speed = 0;
    private int strength = 0;
    private int intellect = 0;

    public int Stamina { get { return stamina; } set { stamina = value; } }

    public int Strength { get { return strength; } set { strength = value; } }

    public int Health { get { return health; } set { health = value; } }

    public int Speed { get { return speed; } set { speed = value; } }

    public int Intellect { get { return intellect; } set { intellect = value; } }
}



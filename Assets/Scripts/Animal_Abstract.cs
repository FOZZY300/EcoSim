using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal_Abstract : MonoBehaviour
{
    public string animalName;
    public int currencyGain;
    public bool herbivore;
    public bool carnivore;

}

public class bear : Animal_Abstract
{
    public string animalName = "Bear";
    public int currencyGain = 10;
    public bool herbivore = false;
    public bool carnivore = true;

}

public class hare : Animal_Abstract
{
    public string animalName = "Hare";
    public int currencyGain = 3;
    public bool herbivore = true;
    public bool carnivore = false;

}
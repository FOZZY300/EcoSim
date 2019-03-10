using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal_Abstract : MonoBehaviour
{
    public string animalName;
    public int currencyGain;
    public bool herbivore;
    public bool carnivore;
    public int animalSpeed;
    public bool hunts;
    public string[] eatenPrey;
    public string[] eatenPlants;
    public bool canSwim;
    public bool canFly;
    public int maximumHunger;
    public int maximumSleep;
    public int maximumThirst;
    public int breedRate;
    public int maximumHealth;
    public int attackDamage;  

}

public class Bear : Animal_Abstract
{
    public string animalName = "Bear";
    public int currencyGain = 10;
    public bool herbivore = false;
    public bool carnivore = true;
    public int animalSpeed = 5;
    public bool hunts = true;
    public string[] eatenPrey;
    public string[] eatenPlants;
    public bool canSwim = true;
    public bool canFly = false;
    public int maximumHunger = 100;
    public int maximumSleep = 100;
    public int maximumThirst = 100;
    public int breedRate = 1;
    public int maximumHealth = 100;
    public int attackDamage = 20;

    //semitest
    public string animalSex = "F", animalAge = "8";
    public float hungerLevel = 0.8f, tirednessLevel = 0.5f, thirstLevel = 0.8f;
    public int animalID;
    public float hungerDecayRate = 0.0001f, tirednessDecayRate = 0.0002f, thirstDecayRate = 0.0003f;

    public void Selected()
    {
        Info_Panel.OpenBox(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex, animalID);
    }

    internal float GetHungerLevel()
    {
        return hungerLevel;
    }
    internal float GetTirednessLevel()
    {
        return tirednessLevel;
    }
    internal float GetThirstLevel()
    {
        return thirstLevel;
    }

    //semitest

}

public class Hare : Animal_Abstract
{
    public string animalName = "Hare";
    public int currencyGain = 2;
    public bool herbivore = true;
    public bool carnivore = false;
    public int animalSpeed = 8;
    public bool hunts = false;
    public string[] eatenPrey;
    public string[] eatenPlants;
    public bool canSwim = true;
    public bool canFly = false;
    public int maximumHunger = 10;
    public int maximumSleep = 100;
    public int maximumThirst = 20;
    public int breedRate = 10;
    public int maximumHealth = 15;
    public int attackDamage = 3;

    //semitest
    public string animalSex = "M", animalAge = "4";
    public float hungerLevel = 0.4f, tirednessLevel = 0.4f, thirstLevel = 0.4f;
    public int animalID;
    public float hungerDecayRate = 0.0001f, tirednessDecayRate = 0.0002f, thirstDecayRate = 0.0003f;

    public void Selected()
    {
        Info_Panel.OpenBox(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex, animalID);
    }

    internal float GetHungerLevel()
    {
        return hungerLevel;
    }
    internal float GetTirednessLevel()
    {
        return tirednessLevel;
    }
    internal float GetThirstLevel()
    {
        return thirstLevel;
    }

    //semitest

}

public class Moose : Animal_Abstract
{
    public string animalName = "Moose";
    public int currencyGain = 6;
    public bool herbivore = true;
    public bool carnivore = false;
    public int animalSpeed = 8;
    public bool hunts = false;
    public string[] eatenPrey;
    public string[] eatenPlants;
    public bool canSwim = true;
    public bool canFly = false;
    public int maximumHunger = 50;
    public int maximumSleep = 100;
    public int maximumThirst = 50;
    public int breedRate = 2;
    public int maximumHealth = 40;
    public int attackDamage = 10;
}

public class Wolf : Animal_Abstract
{
    public string animalName = "Wolf";
    public int currencyGain = 12;
    public bool herbivore = false;
    public bool carnivore = true;
    public int animalSpeed = 10;
    public bool hunts = true;
    public string[] eatenPrey;
    public string[] eatenPlants;
    public bool canSwim = true;
    public bool canFly = false;
    public int maximumHunger = 100;
    public int maximumSleep = 100;
    public int maximumThirst = 75;
    public int breedRate = 3;
    public int maximumHealth = 75;
    public int attackDamage = 20;
}


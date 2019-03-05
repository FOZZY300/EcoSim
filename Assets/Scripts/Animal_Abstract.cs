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


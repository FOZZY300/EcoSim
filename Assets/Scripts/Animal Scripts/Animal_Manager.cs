using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Manager : MonoBehaviour
{
    private static int i = 0; 
    private static GameObject temp;
    private static List<GameObject> clones = new List<GameObject>();
    private static Dictionary<int, GameObject> cloneID = new Dictionary<int, GameObject>();
    private static Hare_Script hScript;
    private static Bear_Script bScript;
    private static Moose_Script mScript;
    private static Wolf_Script wScript;

    /*
    public static void NewAnimal(string animal, Vector3 place)
    {
        clones.Add(Instantiate(GameObject.Find(animal)));
        clones[i].transform.position = place;
        cloneID.Add(clones[i].GetInstanceID(), clones[i]);       
        temp = cloneID[clones[i].GetInstanceID()];
        switch (animal)
        {
            case "Bear":
                bScript = temp.GetComponent<Bear_Script>();
                bScript.SetAnimalID(clones[i].GetInstanceID());
                break;

            case "Hare":
                hScript = temp.GetComponent<Hare_Script>();
                hScript.SetAnimalID(clones[i].GetInstanceID());
                break;
                
            case "Moose":
                mScript = temp.GetComponent<Moose_Script>();
                mScript.SetAnimalID(clones[i].GetInstanceID());
                break;

            case "Wolf":
                wScript = temp.GetComponent<Wolf_Script>();
                wScript.SetAnimalID(clones[i].GetInstanceID());
                break;



            default:
                break;

        }               
        i++;
    }

    public static float GetHungerLevel(int animalID, string animalName)
    {
        Debug.Log(animalID + "GetHungerLevel");
        temp = cloneID[animalID];
        switch (animalName)
        {
            case "Bear":
                bScript = temp.GetComponent<Bear_Script>();
                return bScript.GetHungerLevel();

            case "Hare":
                hScript = temp.GetComponent<Hare_Script>();
                return hScript.GetHungerLevel();
                
            case "Moose":
                mScript = temp.GetComponent<Moose_Script>();
                return mScript.GetHungerLevel();

            case "Wolf":
                wScript = temp.GetComponent<Wolf_Script>();
                return wScript.GetHungerLevel();

            default:
                return 0;

        }
    }

    public static float GetTirednessLevel(int animalID, string animalName)
    {
        Debug.Log(animalID + "GetTirednessLevel");
        temp = cloneID[animalID];
        switch (animalName)
        {
            case "Bear":
                bScript = temp.GetComponent<Bear_Script>();
                return bScript.GetTirednessLevel();

            case "Hare":
                hScript = temp.GetComponent<Hare_Script>();
                return hScript.GetTirednessLevel();
                
            case "Moose":
                mScript = temp.GetComponent<Moose_Script>();
                return mScript.GetTirednessLevel();

            case "Wolf":
                wScript = temp.GetComponent<Wolf_Script>();
                return wScript.GetTirednessLevel();

            default:
                return 0;

        }
    }

    public static float GetThirstLevel(int animalID, string animalName)
    {
        Debug.Log(animalID + "GetThirstLevel");
        temp = cloneID[animalID];
        switch (animalName)
        {
            case "Bear":
                bScript = temp.GetComponent<Bear_Script>();
                return bScript.GetThirstLevel();

            case "Hare":
                hScript = temp.GetComponent<Hare_Script>();
                return hScript.GetThirstLevel();
                
            case "Moose":
                mScript = temp.GetComponent<Moose_Script>();
                return mScript.GetThirstLevel();

            case "Wolf":
                wScript = temp.GetComponent<Wolf_Script>();
                return wScript.GetThirstLevel();

            default:
                return 0;

        }
    } 
    */
}

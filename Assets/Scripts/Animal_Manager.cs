using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Manager : MonoBehaviour
{
    static int i = 0; 
    static GameObject temp;
    static List<GameObject> clones = new List<GameObject>();
    static Dictionary<int, GameObject> cloneID = new Dictionary<int, GameObject>();
    static Bear_Script script;

    public static void NewAnimal(string animal, Vector3 place)
    {
        clones.Add(Instantiate(GameObject.Find(animal)));
        clones[i].transform.position = place;
        cloneID.Add(clones[i].GetInstanceID(), clones[i]);       
        temp = cloneID[clones[i].GetInstanceID()];
        script = temp.GetComponent<Bear_Script>();
        script.SetAnimalID(clones[i].GetInstanceID());
        i++;
    }

    public static float GetHungerLevel(int animalID)
    {
        Debug.Log(animalID + "GetHungerLevel");
        temp = cloneID[animalID];
        script = temp.GetComponent<Bear_Script>();        
        return script.GetHungerLevel();      
    }

    public static float GetTirednessLevel(int animalID)
    {
        Debug.Log(animalID + "GetTirednessLevel");
        temp = cloneID[animalID];
        script = temp.GetComponent<Bear_Script>();
        return script.GetTirednessLevel();
    }

    public static float GetThirstLevel(int animalID)
    {
        Debug.Log(animalID + "GetThirstLevel");
        temp = cloneID[animalID];
        script = temp.GetComponent<Bear_Script>();
        return script.GetThirstLevel();
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Grass_Script : MonoBehaviour
{
    public Sprite seed;
    public Sprite sapling;
    public Sprite plant;
    private SpriteRenderer spriteRenderer;
    private static System.Timers.Timer seedTimer;
    private static System.Timers.Timer saplingTimer;

    private bool setSpriteSapling = false;
    private bool setSpritePlant = false;
   

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        Debug.Log("Start ran");

        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = seed;
        }
     
        startSeedTimer();

    }

    // Update is called once per frame
    void Update()
    {
        if (setSpriteSapling == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sapling;
            setSpriteSapling = false;
        } else if (setSpritePlant == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = plant;
            setSpritePlant = false;
        }
    }

    private void startSeedTimer()
    {
        Debug.Log("seed timer has started");
        seedTimer = new System.Timers.Timer(3000);
        seedTimer.Elapsed += setSapling;
        seedTimer.AutoReset = false;
        seedTimer.Enabled = true;
    }

    private void startSaplingTimer()
    {
        Debug.Log("sapling timer has gone off");
        saplingTimer = new System.Timers.Timer(3000);
        saplingTimer.Elapsed += setPlant;
        saplingTimer.AutoReset = false;
        saplingTimer.Enabled = true;
    }

    private void setSapling(object source, ElapsedEventArgs e)
    {
        Debug.Log("timed sapling event");
        this.startSaplingTimer();
        setSpriteSapling = true;
        

    }

    private void setPlant(object source, ElapsedEventArgs e)
    {
        Debug.Log("timed plant event");
        setSpritePlant = true;

    }



}

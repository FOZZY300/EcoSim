using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Plant_Aging_Script : MonoBehaviour
{
    public Sprite stage1;
    public Sprite stage2;
    public Sprite stage3;
    private SpriteRenderer spriteRenderer;
    private static System.Timers.Timer seedTimer;
    private static System.Timers.Timer saplingTimer;

    private bool setSpriteSapling = false;
    private bool setSpritePlant = false;
   

    // Start is called before the first frame update,checks object has a sprite attatched
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        Debug.Log("Start ran");

        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = stage1;
        }
     
        stage1Timer();

    }

    // Update is called once per frame, checks whether to changet the sprite
    void Update()
    {
        if (setSpriteSapling == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = stage2;
            setSpriteSapling = false;
        } else if (setSpritePlant == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = stage3;
            setSpritePlant = false;
        }
    }

    //starts a timer for the first stage of the aging process
    private void stage1Timer()
    {
        Debug.Log("seed timer has started");
        seedTimer = new System.Timers.Timer(5000);
        seedTimer.Elapsed += setStage2;
        seedTimer.AutoReset = false;
        seedTimer.Enabled = true;
    }

    //starts timer for the second stage of the aging process
    private void stage2Timer()
    {
        Debug.Log("sapling timer has gone off");
        saplingTimer = new System.Timers.Timer(5000);
        saplingTimer.Elapsed += setStage3;
        saplingTimer.AutoReset = false;
        saplingTimer.Enabled = true;
    }

    //method called to enable changing of sprite to second stage
    private void setStage2(object source, ElapsedEventArgs e)
    {
        Debug.Log("timed stage 2 event");
        this.stage2Timer();
        setSpriteSapling = true;
        

    }

    //method called to enable changing of sprite to third stage
    private void setStage3(object source, ElapsedEventArgs e)
    {
        Debug.Log("timed stage 3 event");
        setSpritePlant = true;
    }

}

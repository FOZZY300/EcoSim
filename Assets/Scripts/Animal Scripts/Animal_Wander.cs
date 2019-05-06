using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Wander : MonoBehaviour
{
    /*
     * --------------------------
     * SET AS LOW PRIORITY BEHAVIOUR
     *--------------------------- 
     */

    Entities hp = new Entities();
    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;

   

    [SerializeField]
    private Sprite facingLeft;

    public Animator animator;

    private Rigidbody2D myRigidBody;

    public bool isWalking;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    public bool facingRight = true;

    private int walkDirection;

    //Will hopefully be able to develop into DEN system
    public Collider2D playArea;
    private bool hasplayArea;


    // Start is called before the first frame update
    void Start()
    {

        myRigidBody = GetComponent<Rigidbody2D>();

        waitCounter = walkTime;
        walkCounter = walkTime;

        ChooseDirection();

    /*    if (playArea != null)
        {
            minWalkPoint = playArea.bounds.min;
            maxWalkPoint = playArea.bounds.max;
            hasplayArea = true;
        }
        */
    }


    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        if (move < 0) GetComponent<Rigidbody2D>().velocity = new Vector3(move * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if (move > 0) GetComponent<Rigidbody2D>().velocity = new Vector3(move * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);


    }

    // Update is called once per frame
    void Update()
    {

        

        if (hp.health <= 30f)
        {
            moveSpeed = moveSpeed + 0.01f;
        }

        if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            switch (walkDirection)
            {
                case 0:
                    myRigidBody.velocity = new Vector2(0, moveSpeed);
                    animator.SetBool("isWalkingRight", true);
                    if (hasplayArea && transform.position.y > maxWalkPoint.y)
                    {                       
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;

                case 1:
                    myRigidBody.velocity = new Vector2(moveSpeed, 0);
                    animator.SetBool("isWalkingRight", true);
                    if (hasplayArea && transform.position.x > maxWalkPoint.x)
                    {                    
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;

                case 2:
                    myRigidBody.velocity = new Vector2(0, -moveSpeed);
                    animator.SetBool("isWalkingLeft", true);
                    if (hasplayArea && transform.position.y < minWalkPoint.y)
                    {                        
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;

                case 3:
                    myRigidBody.velocity = new Vector2(-moveSpeed, 0);
                    animator.SetBool("isWalkingLeft", true);
                    if (hasplayArea && transform.position.x < minWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;

            }

            if (walkCounter < 0)
            {
                isWalking = false;
                animator.SetBool("isWalkingRight", false);
                animator.SetBool("isWalkingLeft", false);
                waitCounter = waitTime;
            }
        }

        else
        {
            waitCounter -= Time.deltaTime;

            myRigidBody.velocity = Vector2.zero;

            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }

    public void ChooseDirection()
    {
       
        walkDirection = Random.Range(0, 4);

        isWalking = true;
                    
        walkCounter = walkTime;
    }

}

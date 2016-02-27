using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Creature : MonoBehaviour
{

    public bool isIdle = true;

    //Raycast Code
   // private RaycastHit2D rayCastHit;
   // private const float RAYCASTDIST = 5f; good coding practice to not hard code values

    //health
    private int health;
    public int Health
    {
        get { return health; }
        protected set { health = value; }
    }

    public void AdjustHealth(int amount)
    {
        if (health < 0)
            health += amount;
    }

    //abilities
    private List<Ability> abilities;

    //attack
    public virtual IEnumerator Attack(Ability ab)
    {
        Debug.Log(this.gameObject.name + " is Attacking!");
        ab.Use();
        isIdle = true;
        StartCoroutine(Idle());
        yield return null;
    }

    //death

    //idle
    public virtual IEnumerator Idle()
    {
        // Vector2 dir = this.transform.TransformDirection(Vector2.left) * RAYCASTDIST; //used for debug draw ray cast

        while (isIdle)
        {
            /*
            //We will not be using this for our project but this is a way to setup some quick ray casting

            rayCastHit = Physics2D.Raycast(this.transform.position, Vector2.left, RAYCASTDIST); //fires the ray from the transform position to the left for a distance return the hit object
            Debug.DrawRay(this.transform.position, dir, Color.red); //debug statement to see the ray to test
            if(rayCastHit.collider != null && rayCastHit.collider.gameObject.name == "CharacterRobotBoy")   //rememeber not the best way to search for gameobjects but good for testing. Check out layers in unity for better sorting.
            {
                Debug.Log(this.gameObject.name + " spotted the player!");
            }
            else
            {
                Debug.Log(this.gameObject.name + " is searching.");
            }*/

            yield return null;

        }
        


        yield return null;
    }

   
    void Awake()
    {
        StartCoroutine(Idle());
    }


    void Update()
    {

    }

    


}
 
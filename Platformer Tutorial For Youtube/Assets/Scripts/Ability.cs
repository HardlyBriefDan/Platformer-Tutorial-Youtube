using UnityEngine;
using System.Collections;

public class Ability
{
    private string name;
    private int damageAmt;

    public virtual void Use()
    {
        //ability going performed here
        Debug.Log("Ability used!"); //for testing
    }

}

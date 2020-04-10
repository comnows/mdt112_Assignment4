using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject GoalObject;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.Equals (GoalObject))
        {
        Debug.Log("You Win");
        }
    }
}

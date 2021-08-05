using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerMove : MonoBehaviour
{
    private Animator movement;
    private Animator wallMovement;

    // Start is called before the first frame update
    void Start()
    {
        string subname = gameObject.name.Substring(gameObject.name.IndexOf("("));
        movement = gameObject.GetComponent<Animator>();
        wallMovement = GameObject.Find("wall " + subname).GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    void OnTriggerEnter(Collider col)
    {
        if (col != null && col.name == "playerTrigger")
        {
            
            movement.SetBool("enter", true);
            wallMovement.SetBool("enter", true);

            //movement.SetBool("leave", false);
        }
    }

    //void OnTriggerExit(Collider col)
    //{
    //    if (col != null && col.name == "playerTrigger")
    //    {
    //        movement.SetBool("enter", false);
    //        movement.SetBool("leave", true);
    //    }
    //}

}

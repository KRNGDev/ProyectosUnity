using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

   private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
    
        characterController= GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float hori= Input.GetAxis("Horizontal");
        float ver= Input.GetAxis("Vertical");
        if(hori!=0|| ver != 0){

        characterController.Move(transform.forward*4*Time.deltaTime);
        }
    }
}

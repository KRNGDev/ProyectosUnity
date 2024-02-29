using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rbPajaro;
    public float potencia = 20f;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        rbPajaro = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        Vector3 positionPlayer = player.position;

        if (positionPlayer.y > 8)
        {
            transform.position = new Vector3(positionPlayer.x, 8, positionPlayer.z);
            rbPajaro.AddForce(Vector3.down*potencia, ForceMode.Impulse);

        }
        else if (positionPlayer.y < -2)
        {
            transform.position = new Vector3(positionPlayer.x, -2, positionPlayer.z);
            rbPajaro.AddForce(Vector3.up*potencia, ForceMode.Impulse);
        }




        
        rbPajaro.AddForce(Vector3.right * hor*5);
         
        if(Input.GetKeyDown(KeyCode.UpArrow)){

            rbPajaro.AddForce(Vector3.up *  potencia, ForceMode.Impulse);

        }





    }
}

using System.Collections;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rbPajaro;
    public float potencia = 20f;
    public Transform player;
    private AudioSource audioJump;
    private int puntuacionMax;
    public TMP_Text textMaxPoint;

    // Start is called before the first frame update
    void Start()
    {
         if (PlayerPrefs.HasKey("puntuacion")) 
        {
            puntuacionMax = PlayerPrefs.GetInt("puntuacion");
            textMaxPoint.GetComponentInChildren<TextMeshProUGUI>().SetText(puntuacionMax.ToString());
        }
        else 
        {
            puntuacionMax = 0;
        }
        if (rbPajaro != null || player != null)
        {
            rbPajaro = GetComponent<Rigidbody>();
            audioJump = GetComponent<AudioSource>();//Sonido del salto
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rbPajaro != null || player != null)
        {
            Vector3 positionPlayer = player.position;

            //Evitar que salga mas arriba de pantalla  o mas abajo

            if (positionPlayer.y > 8)
            {
                transform.position = new Vector3(positionPlayer.x, 8, positionPlayer.z);
                rbPajaro.AddForce(Vector3.down * potencia, ForceMode.Impulse);

            }
            else if (positionPlayer.y < -2)
            {

                transform.position = new Vector3(positionPlayer.x, -2, positionPlayer.z);
                rbPajaro.AddForce(Vector3.up * potencia, ForceMode.Impulse);

            }





            // rbPajaro.AddForce(Vector3.right * hor*5);
            //Pulsa boton arriba para desplazar 

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {

                rbPajaro.AddForce(Vector3.up * potencia, ForceMode.Impulse);
                audioJump.Play();
            }



        }

    }
}

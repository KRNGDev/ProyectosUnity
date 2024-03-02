using TMPro;//PARA LA PUNTUACIÓN EN LA UI
using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    public GameObject prefabExplosion;   
    public GameObject botonReset;

    
void Start(){

    
}
    void OnCollisionEnter()
    {
        Instantiate(prefabExplosion, transform.position, prefabExplosion.transform.rotation);
    
        Destroy(gameObject);
       botonReset.SetActive(true);

    }
}
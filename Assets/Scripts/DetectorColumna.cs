using TMPro;//PARA LA PUNTUACIÓN EN LA UI
using UnityEngine;

public class DetectorColumnas : MonoBehaviour
{

    public TMP_Text textObject;//PARA LA PUNTUACIÓN EN LA UI

    public int puntuacion = 0;
    public int puntosPorColumna = 1;

    void OnTriggerExit()
    {
        puntuacion = puntuacion + puntosPorColumna;
        textObject.GetComponentInChildren<TextMeshProUGUI>().SetText(puntuacion.ToString());//PARA LA PUNTUACIÓN EN LA UI
    }
}
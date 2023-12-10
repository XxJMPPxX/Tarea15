using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarPuntaje : MonoBehaviour
{
    public int puntos;
    public Text puntajetexto;

    public void CantidadPuntos(int Score)
    {
        puntos = puntos + Score;
        puntajetexto.text = "Puntos: " + puntos;
    }
    void Start()
    {
        CantidadPuntos(0);
    }
}

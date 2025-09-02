using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public int vida;

    public int puntos;

    [SerializeField]

    private TMP_Text Puntos;

    [SerializeField]
    private TMP_Text Vida;

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        Puntos.text = "Score: " + puntos;
    }

    public void RestarVida(int value)
    {
        vida -= value;
        Vida.text = "HP: " + vida;
    }

}
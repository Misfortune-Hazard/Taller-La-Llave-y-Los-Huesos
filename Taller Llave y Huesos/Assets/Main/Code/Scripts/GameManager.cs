using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int vida;

    public int puntos;

    [SerializeField]

    private TMP_Text textoPuntos;

    [SerializeField]
    private TMP_Text textoVida;

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        textoPuntos.text = "Puntos: " + puntos;
    }

    public void RestarVida(int value)
    {
        vida -= value;
        textoVida.text = "Vida: " + vida;

    }

    public void CompararPuntos(int value)

    {
        if (puntos == value)
        {
            puntos = 0;
            textoPuntos.text = "Puntos: " + puntos;
        }
    }

    public void SumarVida(int value)
    {
        vida += value;
        textoVida.text = "Vida: " + vida;

    }

}

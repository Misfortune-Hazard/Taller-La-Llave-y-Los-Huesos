using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int vida;

    public int puntos;

    public int llave;

    public int victoria;

    [SerializeField]

    private TMP_Text textoPuntos;

    [SerializeField]
    private TMP_Text textoVida;

    [SerializeField]
    private TMP_Text textoLlave;

    [SerializeField]
    private TMP_Text textoVictoria;

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

    public void SumarLlave(int claves)
    {
        llave += claves;
        if (llave == 0)
        {
            textoLlave.text = "Llave: No";
        }

        else
        {
            textoLlave.text = "Llave: Si";
        }

    }

    public void CompararLlaves(int value)

    {
        if (llave == value)
        {
            llave = 0;
        }
    }

    public void LlamarVictoria(int value)

    {
            victoria += value;
            textoVictoria.text = "Ganaste";
    }

    public void EstadosDeJuego(string estado)
    {
        switch(estado)
        {
            case "Ganaste":
                //
                break;
            case "Perdiste":
                //
                break;
            case "Pausa":
                //
                break;
            case "Jugando":
                //
                break;
        }
    }

    public void ActualizarUI(string estado)
    {
        switch(estado)
        {
            case "Vida":
                textoVida.text = "Vida: " + vida;
                break;
            case "Puntos":
                textoPuntos.text = "Puntos: " + puntos;
                break;
            case "Victoria":
                textoVictoria.text = "Ganaste";
                break;
            //case "Llave":
                //
                //break;
        }
    }

}

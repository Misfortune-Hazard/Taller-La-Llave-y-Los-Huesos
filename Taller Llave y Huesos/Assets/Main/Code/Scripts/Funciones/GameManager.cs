using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    [SerializeField]
    private UIManager uIManager;

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        textoPuntos.text = "Puntos: " + puntos;
    }

    public void RestarVida(int value)
    {
        vida -= value;
        uIManager.UpdateHearts(1, 5);
        //textoVida.text = "Vida: " + vida;
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
        //textoVida.text = "Vida: " + vida;
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
        if (llave >= value)
        {
            llave = 0;
            EstadosDeJuego("Ganaste");
        }
    }

    public void LlamarVictoria(int value)

    {
            victoria += value;
            //textoVictoria.text = "Ganaste";
    }

    public void EstadosDeJuego(string estado)
    {
        switch(estado)
        {
            case "Ganaste":
                SceneManager.LoadScene(1);
                break;
            case "Perdiste":
                SceneManager.LoadScene(3);
                break;
            case "Pausa":
                //
                break;
            case "Jugando":
                SceneManager.LoadScene(2);
                break;
        }
    }

    
}

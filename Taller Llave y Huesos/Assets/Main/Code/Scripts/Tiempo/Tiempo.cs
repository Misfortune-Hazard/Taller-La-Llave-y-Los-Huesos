using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour

{
    public bool runningTimer;

    [SerializeField]
    TextMeshProUGUI textoTiempo;

    [SerializeField]
    public float tiempoRestante;

    [SerializeField]
    private GameManager gameManager;

    private void Update()

    {
        if (tiempoRestante > 0)

        {
            tiempoRestante -= Time.deltaTime;
        }
        else if (tiempoRestante <= 0)

        {
            tiempoRestante = 0;
            gameManager.EstadosDeJuego("Perdiste");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        int minutes = Mathf.FloorToInt(tiempoRestante / 60);
        int seconds = Mathf.FloorToInt(tiempoRestante % 60);
        textoTiempo.text = string.Format("{00:00}:{1:00}", minutes, seconds);
    }

    public void Sumartiempo(float segundos)

    {
        tiempoRestante += segundos;

    }
}

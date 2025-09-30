using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salud : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void Update()
    {
        if (gameManager.vida <= 0)
        {
            gameManager.EstadosDeJuego("Perdiste");
            //SceneManager.LoadScene(1);
        }
    }
}

    
    //[SerializeField] private float saludInicial;
    //private float saludActual;

    //private void Awake()
    //{
        //saludActual = saludInicial;

    //}

    //public void Herido(float _dano)
    //{
        //saludActual = Mathf.Clamp(saludActual - _dano, 0, saludInicial);

        //if (saludActual >= 0)
        //{

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //}
        
    //}
//}
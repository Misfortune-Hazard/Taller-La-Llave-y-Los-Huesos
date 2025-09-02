using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUNTOS : MonoBehaviour
{
    [SerializeField] private GameObject efecto;
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            puntaje.SumarPuntos(cantidadPuntos);

            Destroy(this.gameObject);

        }
    }


}

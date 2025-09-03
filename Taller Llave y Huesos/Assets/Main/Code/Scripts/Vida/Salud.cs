using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    [SerializeField] private float saludInicial;
    private float saludActual;

    private void Awake()
    {
        saludActual = saludInicial;

    }

    public void Herido(float _dano)
    {
        saludActual = Mathf.Clamp(saludActual - _dano, 0, saludInicial);

        if (saludActual >- 0)
        {



        }
        else
        {

        }


    }
}
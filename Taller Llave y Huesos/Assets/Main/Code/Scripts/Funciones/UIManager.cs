//using Microsoft.Unity.VisualStudio.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{

    [SerializeField]
    private GameObject[] heartObject;
    [SerializeField]
    private Image[] heartSprite;
    [SerializeField]
    private GameManager gameManager;

    public void UpdateHearts(int vida, int vidamax)
    {
        //if (heartObject == null) return;
        vida = gameManager.vida;
        vidamax = 5;
        for (int i = 0; i < vidamax; i++)
        {
            if (vida == i)
            heartSprite[i].enabled = false;
        //if (heartObject[i] |= null)
        //hearts[i].SetActive[i < currentLives];
        }

        //heartObject[0].SetActive(false);

    }

}

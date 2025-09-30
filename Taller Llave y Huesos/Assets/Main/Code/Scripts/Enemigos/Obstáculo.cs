using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstáculo : MonoBehaviour
{

    [SerializeField]
    private GameManager gameManager;

        private void Update()
    {
        if (gameManager.puntos >= 10)

        {
            Destroy(this.gameObject);
        }
    }

}
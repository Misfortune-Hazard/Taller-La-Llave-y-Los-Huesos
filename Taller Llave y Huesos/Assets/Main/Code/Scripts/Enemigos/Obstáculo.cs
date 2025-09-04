using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstáculo : MonoBehaviour
{

    [SerializeField]
    private GameManager gameManager;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            gameManager.CompararPuntos(10);
            Destroy(this.gameObject);
        }

    }

}
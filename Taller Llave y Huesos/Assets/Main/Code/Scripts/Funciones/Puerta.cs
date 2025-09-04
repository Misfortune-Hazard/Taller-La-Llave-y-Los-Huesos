using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            gameManager.CompararLlaves(1);
            Time.timeScale = 0;
        }

    }
}

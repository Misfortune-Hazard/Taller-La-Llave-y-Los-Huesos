using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (gameManager.llave == 1)

        {
            gameManager.CompararLlaves(1);
            gameManager.LlamarVictoria(1);
            Time.timeScale = 0;
        }
        
    }
}
//collision.gameObject.tag == "Player" + 
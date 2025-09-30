using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Espinas : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if (collision.tag == "Player")
        {
            gameManager.RestarVida(1);
            //SceneManager.LoadScene(1);

        }
    }
}

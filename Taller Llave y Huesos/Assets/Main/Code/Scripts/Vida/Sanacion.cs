using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanacion : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Colisi�n");
        if (collision.tag == "Player")
        {
            gameManager.SumarVida(10);
            Debug.Log("Colisi�n");
            Destroy(this.gameObject);
            //SceneManager.LoadScene(1);

        }
    }
}

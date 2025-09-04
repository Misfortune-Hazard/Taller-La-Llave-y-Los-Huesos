using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{

    [SerializeField]
    private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Player")

        {
            gameManager.SumarLlave(1);
            Destroy(this.gameObject);
        }
    }

}

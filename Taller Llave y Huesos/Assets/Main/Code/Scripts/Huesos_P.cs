using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huesos_P : MonoBehaviour
{
    [SerializeField]
    private gameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)

    {if (collision.gameObject.tag == "Player");

    {
        gameManager.SumarPuntos(1);
        Destroy(this.gameObject);
}
}
}




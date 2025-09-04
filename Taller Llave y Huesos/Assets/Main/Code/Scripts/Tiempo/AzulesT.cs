using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzulesT : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private Tiempo Tiempo;
    public float segundosextra = 10f;

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Player")

        { 

            Tiempo.Sumartiempo(10);
            Destroy(this.gameObject);
        }
    }

}

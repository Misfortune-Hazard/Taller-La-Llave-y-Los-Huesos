using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Playercontrol : MonoBehaviour
{

    [SerializeField]

    private Rigidbody2D rb2d;

    [SerializeField]

    private float fuerzasalto;

    [SerializeField]

    private Vector2 direccionsalto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(direccionsalto * fuerzasalto);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Translate(Vector2.left * Time.deltaTime * 5);
            //rb2d.velocity = new Vector2(-1 * 5, 1 * 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Translate(Vector2.right * Time.deltaTime * 5);
            //rb2d.velocity = new Vector2(1 * 5, 1 * 0);
        }
        
    }
}

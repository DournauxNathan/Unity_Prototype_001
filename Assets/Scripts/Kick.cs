using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public GameObject bombGameObject;
    private Rigidbody2D bombRigidbody;

    public bool isKicked;
    public float kickForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        isKicked = false;
        bombRigidbody = bombGameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        KickBomb();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            isKicked = true;
        }
    }

    void KickBomb()
    {
        if (isKicked == true && Input.GetKey(KeyCode.O))
        {
           bombRigidbody.velocity = new Vector2(kickForce, kickForce * 2);
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            isKicked = false;
        }
    }
}

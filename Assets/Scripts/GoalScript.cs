using System.Collections;
using UnityEngine;

public class GoalScript : MonoBehaviour
{ 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GoalB")
        {
            ScoreScript.scoreValueB++;
        }

        if (collision.gameObject.tag == "GoalA")
        {
            ScoreScript.scoreValueA++;
        }
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValueA;
    public static int scoreValueB;
    public Text scoreTextA;
    public Text scoreTextB;
    Text scoreA;
    Text scoreB;

    // Start is called before the first frame update
    void Start()
    {
        scoreA = scoreTextA.GetComponent<Text>();
        scoreB = scoreTextB.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreA.text = "" + scoreValueA;
        scoreB.text = "" + scoreValueB; 
    }
}

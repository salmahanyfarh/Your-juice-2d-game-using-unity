using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    private GameObject ApplePlayer;
    private Vector3 playerInitialPos;

    public Text scoreText;
    private int score;

    // Start is called before the first frame update
    void Awake()
    {
        ApplePlayer = GameObject.FindWithTag("Player");
        playerInitialPos = ApplePlayer.transform.position;

    }

    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Player")
        {

            target.transform.position = playerInitialPos;

            score ++;
            scoreText.text = score.ToString();

        }

    }


} // class

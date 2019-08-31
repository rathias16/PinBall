using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {


    private int score;

    private GameObject scoreText;

    private float visiblePosZ = -6.5f;

    private GameObject gameOverText;

	// Use this for initialization
	void Start () {
        gameOverText = GameObject.Find("GameOverText");
        scoreText = GameObject.Find("ScoreText");
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z < visiblePosZ)
            this.gameOverText.GetComponent<Text>().text = "Game Over";

        this.scoreText.GetComponent<Text>().text = "Score: " + score;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 10;
        }
        else if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 5;
        } 
        else if(collision.gameObject.tag == "LargeCloudTag")
        {
            score += 30;
        }
        else if(collision.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }
    }
}

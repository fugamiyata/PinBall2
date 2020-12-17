using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    

    public GameObject scoreText ;

    public int score = 0;

    void Start()
    {
        // シーン中のscoretextオブジェクトを表示
        this.scoreText = GameObject.Find("scoreText");


        score = 0;
        SetScore();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 15;

        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 7;
        }

        SetScore();
    }

    void SetScore()
    {
        this.scoreText.GetComponent<Text>().text = "得点：" + score;
    }

}

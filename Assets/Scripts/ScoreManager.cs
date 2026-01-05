using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    int highScore;

    void Awake()
    {
        if(instance==null)
        {
            instance =this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        highScore=PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        if(score>highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            
        }
    }
    public void ScoreIncrement()
    {
        score++;
        //Debug.Log(score);
    }
    public void StopScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
    }
}

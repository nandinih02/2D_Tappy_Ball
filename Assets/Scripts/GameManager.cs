using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void GameStart()
    {
        gameOver=false;
        UIManager.instance.GameStart();
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().StartSpawningPipes();
    }
    public void GameOver()
    {
        gameOver=true;
        ScoreManager.instance.StopScore();
        UIManager.instance.GameOver();
        //PipeBehaviour.instance.StopPipes();
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().StopSpawningPipes();

        
    }

}

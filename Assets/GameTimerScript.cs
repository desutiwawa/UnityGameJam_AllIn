using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTimerScript : MonoBehaviour
{

    public float gameTime = 10.0f;

    [SerializeField] private string Result;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameTime -= Time.deltaTime;
        if(gameTime <= 0 )
        {
            SceneManager.LoadScene("Result");
        }

    }
}

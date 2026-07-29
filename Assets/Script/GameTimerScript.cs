using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimerScript : MonoBehaviour
{

    public float gameTime = 60.0f;

    public TextMeshProUGUI timeText;

    [SerializeField] private string Result;

    public Text timerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameTime -= Time.deltaTime;

        //timerText.text = gameTime.ToString("gameTime");

        if(gameTime <= 0 )
        {
            SceneManager.LoadScene("Result");
        }

        timeText.text = "TIME : " + Mathf.Ceil(gameTime);

    }
}

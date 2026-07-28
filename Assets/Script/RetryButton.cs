
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void ClickRetryButton()
    {
        SceneManager.LoadScene("Map_v1");
    }
}


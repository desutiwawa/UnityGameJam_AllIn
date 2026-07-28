
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearButton : MonoBehaviour
{
    public void ClickGameClearButton()
    {
        SceneManager.LoadScene("GameClear");
    }
}


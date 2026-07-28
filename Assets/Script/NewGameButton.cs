
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    public void ClickNewGameButton()
    {
        SceneManager.LoadScene("Map_v1");
    }
}

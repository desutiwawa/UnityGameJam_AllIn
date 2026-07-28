
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public void ClickTitleButton()
    {
        SceneManager.LoadScene("Title");
    }
}



using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialButton : MonoBehaviour
{
    public void ClickTutorialButton()
    {
        SceneManager.LoadScene("Tutorial");
    }
}


using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    public void ClickNextButton()
    {
        SceneManager.LoadScene("Title");
    }
}

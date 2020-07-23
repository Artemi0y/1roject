using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void LoadingScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);

    }
    public void Exit()
    {
        Application.Quit();

    }
}

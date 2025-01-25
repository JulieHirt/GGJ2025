using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager:MonoBehaviour
{
    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
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

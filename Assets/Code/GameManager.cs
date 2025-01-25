using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager:MonoBehaviour
{
    public void Lose()
    {
        //reload the scene when player loses
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}

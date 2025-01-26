using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager:MonoBehaviour
{
    private int levelNum = 1;
    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Lose()
    {
        //reload the scene when player loses
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Win()
    {
        int numLevels = 5;//the number of levels in the game
        levelNum += 1;
        string sceneName = "Level"+levelNum.ToString();

        if (levelNum < 5)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            SceneManager.LoadScene("Win");
        }

    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}

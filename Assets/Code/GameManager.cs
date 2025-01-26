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
        levelNum += 1;
        string sceneName = "Level"+levelNum.ToString();

        try
        {
            SceneManager.LoadScene(sceneName);
        }
        catch
        {
            //TODO: Load the win scene if all levels are beaten
            //SceneManager.LoadScene("Win");
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

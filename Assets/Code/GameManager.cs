using System.Collections;
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
        //wait 1 sec then reload the scene when player loses
        StartCoroutine(Wait());

        
    }
    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Win()
    {
        int numLevels = 5;//the number of levels in the game
        levelNum += 1;
        string sceneName = "Level"+levelNum.ToString();

        if (levelNum < numLevels)
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

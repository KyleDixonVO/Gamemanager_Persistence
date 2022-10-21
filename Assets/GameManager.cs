using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GUIStyle style = new GUIStyle();
    public static GameManager gameManager;
    public static int gameManagerCount;
    public int index;
    // Start is called before the first frame update

    void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
            gameManagerCount++;
        }
        else if (gameManager != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        style.normal.textColor = Color.blue;
        style.fontSize = 14;

    }

    // Update is called once per frame
    void Update()
    {
        Scene active = SceneManager.GetActiveScene();
        index = active.buildIndex;
        if (active.buildIndex == 0)
        {
            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }

        }
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(900, 50, 100, 100), "GameManager Count: " + gameManagerCount.ToString(), style);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    GUIStyle style = new GUIStyle();
    // Start is called before the first frame update
    void Start()
    {
        style.normal.textColor = Color.green;
        style.fontSize = 20;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        if (GameManager.gameManager.index == 0) return;
            //GUI.Label(new Rect(400, 400, 400, 400), DataStorage.global.health.ToString());

            GUI.Label(new Rect(400, 200, 400, 400), (
            "EXP: " + DataStorage.global.experience.ToString() +
            " Health: " + DataStorage.global.health.ToString() +
            " Mana: " + DataStorage.global.manaPoints.ToString() +
            " Stamina: " + DataStorage.global.staminaPoints.ToString() +
            " Level: " + DataStorage.global.level.ToString() +
            " Score: " + DataStorage.global.score.ToString()), style);


        if (GUI.Button(new Rect(50, 0, 300, 30), "Increase EXP")){
            DataStorage.global.IncreaseEXP();
        }
        if (GUI.Button(new Rect(50, 30, 300, 30), "Decrease EXP")){
            DataStorage.global.DecreaseEXP();
        }
        if (GUI.Button(new Rect(50, 60, 300, 30), "Increase Health")){
            DataStorage.global.IncreaseHealth();
        }
        if (GUI.Button(new Rect(50, 90, 300, 30), "Decrease Health")){
            DataStorage.global.DecreaseHealth();
        }
        if (GUI.Button(new Rect(50, 120, 300, 30), "Increase Mana")){
            DataStorage.global.IncreaseMana();
        }
        if (GUI.Button(new Rect(50, 150, 300, 30), "Decrease Mana")){
            DataStorage.global.DecreaseMana();
        }
        if (GUI.Button(new Rect(50, 180, 300, 30), "Increase Stamina")){
            DataStorage.global.IncreaseStamina();
        }
        if (GUI.Button(new Rect(50, 210, 300, 30), "Decrease Stamina")){
            DataStorage.global.DecreaseStamina();
        }
        if (GUI.Button(new Rect(50, 240, 300, 30), "Increase Level")){
            DataStorage.global.IncreaseLevel();
        }
        if (GUI.Button(new Rect(50, 270, 300, 30), "Decrease Level")){
            DataStorage.global.DecreaseLevel();
        }
        if (GUI.Button(new Rect(50, 300, 300, 30), "Increase Score")){
            DataStorage.global.IncreaseScore();
        }
        if (GUI.Button(new Rect(50, 330, 300, 30), "Decrease Score")){
            DataStorage.global.DecreaseScore();
        }
        if (GUI.Button(new Rect(50, 360, 300, 30), "Save"))
        {
            DataStorage.global.SavePlayerData();
        }
        if (GUI.Button(new Rect(50, 390, 300, 30), "Load"))
        {
            DataStorage.global.LoadPlayerData();
        }

        if (GUI.Button(new Rect(500, 300, 300, 30), "Scene1"))
        {
            GameManager.gameManager.LoadScene1();
        }
        if (GUI.Button(new Rect(500, 330, 300, 30), "Scene2"))
        {
            GameManager.gameManager.LoadScene2();
        }
        if (GUI.Button(new Rect(500, 360, 300, 30), "Scene3"))
        {
            GameManager.gameManager.LoadScene3();
        }
        if (GUI.Button(new Rect(500, 390, 300, 30), "MainMenu"))
        {
            GameManager.gameManager.MainMenu();
        }

    }
}

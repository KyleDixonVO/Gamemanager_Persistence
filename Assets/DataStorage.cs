using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class DataStorage : MonoBehaviour
{

    public static DataStorage global;

    public float experience;
    public int health;
    public float score;
    public int manaPoints;
    public int staminaPoints;
    public int level;

    private void Awake()
    {
        if (global == null)
        {
            global = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (global != this)
        {
            Destroy(gameObject);
        }
    }

    public void ImportGlobalData()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream globalFile = File.OpenRead(Application.persistentDataPath + "/globalData.dat");
        GlobalData globalData = (GlobalData)binaryFormatter.Deserialize(globalFile);
        globalFile.Close();

        //set local globalData vars equal to loadedGlobalData
        

    }

    //public void ExportGlobalData()

    public void SavePlayerData()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream playerFile = File.Create(Application.persistentDataPath + "/playerData.dat");

        PlayerData playerData = new PlayerData();

        playerData.experience = experience;
        playerData.health = health;
        playerData.manaPoints = manaPoints;
        playerData.score = score;
        playerData.staminaPoints = staminaPoints;
        playerData.level = level;

        binaryFormatter.Serialize(playerFile, playerData);
        playerFile.Close();
    }

    public void LoadPlayerData()
    {
        if (File.Exists(Application.persistentDataPath + "/playerData.dat"))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream playerFile = File.Open(Application.persistentDataPath + "/playerData.dat", FileMode.Open);
            PlayerData playerData = (PlayerData)binaryFormatter.Deserialize(playerFile);
            playerFile.Close();

            //set local playerData vars equal to loadedPlayerData
            experience = playerData.experience;
            health = playerData.health;
            manaPoints = playerData.manaPoints;
            staminaPoints = playerData.staminaPoints;
            score = playerData.score;
            level = playerData.level;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseHealth()
    {
        health++;
    }

    public void DecreaseHealth()
    {
        health--;
    }

    public void IncreaseEXP()
    {
        experience++;
    }

    public void DecreaseEXP()
    {
        experience--;
    }

    public void IncreaseMana()
    {
        manaPoints++;
    }

    public void DecreaseMana()
    {
        manaPoints--;
    }

    public void IncreaseStamina()
    {
        staminaPoints++;
    }

    public void DecreaseStamina()
    {
        staminaPoints--;
    }

    public void IncreaseScore()
    {
        score++;
    }

    public void DecreaseScore()
    {
        score--;
    }

    public void IncreaseLevel()
    {
        level++;
    }

    public void DecreaseLevel()
    {
        level--;
    }
}

[Serializable]
public class GlobalData
{

}

[Serializable]
public class PlayerData 
{
    public float experience;
    public int health;
    public float score;
    public int manaPoints;
    public int staminaPoints;
    public int level;
}


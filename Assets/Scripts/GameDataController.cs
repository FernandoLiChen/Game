using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameDataController : MonoBehaviour
{
    public GameObject player;
    public string saveArchive;
    public GameData gameData = new GameData();

    private void Awake()
    {
        saveArchive = Application.dataPath + "gameData.json";

        player = GameObject.FindGameObjectWithTag("Player");

        LoadData();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            LoadData();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            SaveData();
        }
    }

    private void LoadData()
    {
        if (File.Exists(saveArchive))
        {
            string content = File.ReadAllText(saveArchive);
            gameData = JsonUtility.FromJson<GameData>(content);

            Debug.Log("Player position" + gameData.posicion);

            player.transform.position = gameData.posicion;
            player.GetComponent<playerHealth>().health = gameData.healths;
        }
        else
        {
            Debug.Log("Archive does not exist");
        }
    }

    private void SaveData()
    {
        GameData newData = new GameData()
        {
            posicion = player.transform.position,
            healths = player.GetComponent<playerHealth>().health
        };

        string chainJSON = JsonUtility.ToJson(newData);

        File.WriteAllText(saveArchive, chainJSON);

        Debug.Log("Archive saved");
    }
}

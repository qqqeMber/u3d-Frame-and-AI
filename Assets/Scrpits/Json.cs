using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

class Json : MonoBehaviour
{
    public static void SavePlayerJson(Player player)
    {
        string path = Application.persistentDataPath + "/player.json";
        var content = JsonUtility.ToJson(player, true);
        File.WriteAllText(path, content);
    }
  /*  public static PlayerData LoadPlayerJson()
    {
        string path = Application.persistentDataPath + "/player.json";
        if (File.Exists(path))
        {
            var content = File.ReadAllText(path);
            var playerData = JsonUtility.FromJson<PlayerData>(content);
            return playerData;
        }
        else
        {
            Debug.LogError("Save file not found in  " + path);
            return null;
        }
    }
    */

}


using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public Text playerText;

    public void GetPlayerName(string playerName)
    {
        playerText.text = "Hello " + playerName + "!";
        PlayerPrefs.SetString("Player", playerName);
    }
}
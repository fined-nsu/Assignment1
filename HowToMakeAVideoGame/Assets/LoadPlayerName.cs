using UnityEngine;
using UnityEngine.UI;

public class LoadPlayerName : MonoBehaviour
{

    public Text playerText;

    // Start is called before the first frame update
    void Start()
    {
        playerText.text = "Player: " + PlayerPrefs.GetString("Player");
    }
}
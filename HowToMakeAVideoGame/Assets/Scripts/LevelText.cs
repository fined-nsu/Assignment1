using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelText : MonoBehaviour
{
    private Transform level;
    public Text levelText;

    // Update is called once per frame
    void Update()
    {
        levelText.text = "Level: " + SceneManager.GetActiveScene().buildIndex.ToString();
    }
}

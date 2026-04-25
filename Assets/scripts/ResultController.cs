using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour
{
    [SerializeField] Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + PlayerController.score.ToString();
    }

    public void ReStart()
    {
        PlayerController.score = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void ToTitle()
    {
        PlayerController.score = 0;
        SceneManager.LoadScene("TitleScene");
    }
}

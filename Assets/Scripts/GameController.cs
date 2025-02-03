using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {
    public int totalScore;
    public Text scoreText;
    public GameObject gameOver;

    public static GameController instance;
    void Start() {
        // Essa configuração nós permite "instanciar" a classe GameController em outras classes 
        //para ter acesso a todos os atributos public
        instance = this;
    }

    public void UpdateScoreText() {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver() {
        gameOver.SetActive(true);
    }

    public void RestartGame(string levelName) {
        SceneManager.LoadScene(levelName);
    }
}

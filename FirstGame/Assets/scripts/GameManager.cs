
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool GameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
	private static int deaths;
	public Text deathText;

    public void EndGame() {
        if (GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
			IncreaseDeaths();
        }
        
    }

    public void CompleteGame()
    {
        completeLevelUI.SetActive(true);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	  
	public void IncreaseDeaths() {
		deaths = deaths + 1;
		deathText.text = deaths.ToString();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame() {
        Application.Quit();
    }
        
  

    // Update is called once per frame

}

using UnityEngine.SceneManagement;
using UnityEngine;

public class MAINMENU : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Game has been quit.");
        Application.Quit();
    }

}

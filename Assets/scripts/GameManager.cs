using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public LoseWindow LoseWindow;
   public static GameManager instance;

   private void Start()
   {
      instance = this;
   }
   public void Lose()
   {
      LoseWindow.gameObject.SetActive(true);
      LoseWindow.PlayerLose();
      Time.timeScale = 0;
   }
   public void RestartScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Time.timeScale = 1;
   }

   public void LoadScene(int sceneNumber)
   {
      SceneManager.LoadScene(sceneNumber);
      Time.timeScale = 1;
   }
}

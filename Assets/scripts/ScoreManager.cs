using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
   public static ScoreManager Instance { get; set; }
   public int score { get; set; }
   [SerializeField] private TextMeshProUGUI scoreText;

   private void Start()
   {
      Instance = this;
   }

   public void SetScore(int score)
   {
      this.score += score;
      scoreText.text = this.score.ToString();
   }
}
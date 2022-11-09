using UnityEngine;
using UnityEngine.UI;

public class ScoreTrigger : MonoBehaviour
{
    public Text scoreText;
    private short score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Penel"))
        {
            score++;
            scoreText.text = "����: " + score.ToString();

            if (PlayerPrefs.GetInt("score") < score)
                PlayerPrefs.SetInt("score", score);
        }
    }
}

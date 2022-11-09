
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject logoText, scoreText;
    public float rightSpeed = 5f;
    public static bool isStart;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (isStart && logoText != null)
            logoText.transform.Translate(Vector2.right * rightSpeed * Time.deltaTime);
    }

    public void startGame()
    {
        if (isStart)
            return;

        isStart = true;        
        Destroy(logoText, 1f);        
        anim.SetBool("Play", true);

        scoreText.SetActive(true);
    }
}

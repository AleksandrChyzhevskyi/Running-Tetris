using UnityEngine;

public class MoveGamePenel : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        if (StartGame.isStart)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}

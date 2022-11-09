using UnityEngine;

public class Mov : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        if (StartGame.isStart)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime /*Space.World*/);

            if (transform.position.y >= 5.5f)
            {
                Destroy(gameObject);
            }
        }
    }
}

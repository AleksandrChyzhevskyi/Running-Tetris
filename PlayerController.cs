using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector3 targetPos;
    public GameObject player;
    public float speed = 5f;

    private void Update()
    {
        if (StartGame.isStart)
        {
            if (Input.GetMouseButton(0))
            {
                targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }

            float step = speed * Time.deltaTime;

            player.transform.position = Vector3.MoveTowards(
            player.transform.position,
            new Vector3(targetPos.x, targetPos.y, player.transform.position.z),
            step
            );
        }
    }
}

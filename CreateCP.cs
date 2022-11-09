using System.Collections;
using UnityEngine;

public class CreateCP : MonoBehaviour
{
    public float waitTime = 1f;
    public GameObject cP;
    private bool isSpawn;
    private Coroutine spawn;

    private void Update()
    {
        if (StartGame.isStart && !isSpawn)
        {
            spawn = StartCoroutine(spawnCP());
            isSpawn = true;
        }
    }
    IEnumerator spawnCP()
    {
        while (true)
        {
            if (StartGame.isStart)
            {
                Instantiate(cP, new Vector2(Random.Range(-2.25f, 2.3f), -7), Quaternion.identity);
            }
            else
            {
                StopCoroutine(spawn);
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}

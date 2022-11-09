using UnityEngine;

public class CreateBeckground : MonoBehaviour
{
    public GameObject now_Bg, bg_inst;
    private GameObject new_Bg;

    private void Update()
    {
        if (StartGame.isStart)
        {
            if (now_Bg.transform.position.y >= 0f && new_Bg == null)
            {
                CreateNewBg();
            }
            else if (new_Bg != null && new_Bg.transform.position.y >= 0f)
            {
                CreateNewBg();
            }
        }
    }
    void CreateNewBg()
    {
       new_Bg = Instantiate(bg_inst, new Vector2(0f, 12.1f), Quaternion.identity) as GameObject;
    }
}

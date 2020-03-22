using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    private Player player;
    public Text HP;
    // Start is called before the first frame update
    void Start()
    {
        // 获取主角
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = player.life.ToString();
    }
}

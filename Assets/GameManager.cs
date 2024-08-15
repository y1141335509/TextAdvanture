using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       // 只要是在Unity游戏中使用了 UI（例如canvas，text， button等）就必须导入 UnityEngine.UI


public class GameManager : MonoBehaviour
{

    public Text mainText;
    public Button option1;
    public Button option2;


    // Start is called before the first frame update
    void Start()
    {
        mainText.text = "Welcome to my game";
        option1.GetComponentInChildren<Text>().text = "Hello";
        option1.GetComponentInChildren<Text>().text = "Bye!";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

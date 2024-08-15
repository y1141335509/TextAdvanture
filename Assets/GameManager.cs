using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       // 只要是在Unity游戏中使用了 UI（例如canvas，text， button等）就必须导入 UnityEngine.UI


class StoryBlock {
    public string story;
    public string option1Text;
    public string option2Text;
    public StoryBlock option1Block;
    public StoryBlock option2Block;

    public StoryBlock(string story, string option1Text="", string option2Text="", 
    StoryBlock option1Block = null, StoryBlock option2Block = null) {
        this.story = story;
        this.option1Text = option1Text;
        this.option2Text = option2Text;
        this.option1Block = option1Block;
        this.option2Block = option2Block;
    }
}

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

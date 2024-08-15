using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       // 只要是在Unity游戏中使用了 UI（例如canvas，text， button等）就必须导入 UnityEngine.UI


class StoryBlock
{
    public string story;
    public string option1Text;
    public string option2Text;
    public StoryBlock option1Block;
    public StoryBlock option2Block;

    public StoryBlock(string story, string option1Text = "", string option2Text = "",
    StoryBlock option1Block = null, StoryBlock option2Block = null)
    {
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

    StoryBlock currentBlock;

    static StoryBlock block8 = new StoryBlock("You decided to sit here forever. Game Over...");
    static StoryBlock block7 = new StoryBlock("You've approached the wooden doors, insered the key, tirned and... it opens! You are free!");
    static StoryBlock block6 = new StoryBlock("The floor is covered with huge amounts of the small stones. You started to move your hand around them", "Try to unlock doors", "Do nothing", block7, block8);
    static StoryBlock block5 = new StoryBlock("You started reaching into your pockets, but nothing could be found there", "Inspect floor", "Check the doors", block6, block6);
    static StoryBlock block4 = new StoryBlock("Because you quickly get tired of screaming, you decided to sit down and devise an escape route.", "Inspect floor", "Check your bockes", block6, block5);
    static StoryBlock block3 = new StoryBlock("After quick inspection, it looks like they are closed. But there is a key lock!", "Inspect floor", "Do nothing", block6, block8);
    static StoryBlock block2 = new StoryBlock("You started to panic and screamed for help, but it looks like you're here completely alone", "Sit down..", "Stand up", block4, block3);
    static StoryBlock block1 = new StoryBlock("You just woke up in a small, dark cell in an old castle", "Look for other people", "Check the doors", block2, block3);

    // Start is called before the first frame update
    void Start()
    {
        DisplayBlock(block1);   
    }

    void DisplayBlock(StoryBlock block) {
        mainText.text = block.story;
        option1.GetComponentInChildren<Text>().text = block.option1Text;
        option2.GetComponentInChildren<Text>().text = block.option2Text;

        currentBlock = block;
    }

    public void Button1Clicked() {
        DisplayBlock(currentBlock.option1Block);
    }

    public void Button2Clicked() {
        DisplayBlock(currentBlock.option2Block);
    }
}

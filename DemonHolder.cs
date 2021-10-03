using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemonHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite demon1, demon2, demon3, demon4, demon5, demon6, finalDemon;
    public SpriteRenderer spr;
    public GameObject demonDialogueBox;
    public Text textSpace;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeToDemon1()
    {
        spr.sprite = demon1;
        textSpace.text = "LoOoOooveee Meeeee...";
        
        
    }

    public void changeToDemon2()
    {
        spr.sprite = demon2;
        textSpace.text = "Hey name is UwUbert. No relation.";
    }

    public void changeToDemon3()
    {
        spr.sprite = demon3;
        textSpace.text = "*stares lovingly*";
    }

    public void changeToDemon4()
    {
        spr.sprite = demon4;
        textSpace.text = "Daaaang I feel and look cool. Wanna dance baby? No? That's fine too.";
    }

    public void changeToDemon5()
    {
        spr.sprite = demon5;
        textSpace.text = "Eye see everything. All your impure desire. Admirable.";
    }

    public void changeToDemon6()
    {
        spr.sprite = demon6;
        textSpace.text = "Nothing wrong with a good ol'fashion demon from hell.";
    }

    public void changeToFinalDemon()
    {
        spr.sprite = finalDemon;
        textSpace.text = "I am the epitome of beauty. Nothing greater can be summoned.";
    }

    public void turnOnDemonDialogue()
    {
        demonDialogueBox.SetActive(true);
    }

    public void turnOffDemonBox()
    {
        demonDialogueBox.SetActive(false);
        changeToDemon1();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnClickOFFICE : MonoBehaviour
{ 
    public Sprite task1, task2, task3, task4, task5, fun1, fun2, fun3, fun4, fun5;
    public GameObject popup;
    public Image comics;
    
    void Start()
    { 
        popup.SetActive(false);
    }

    void Update(){
    }

    void OnTriggerEnter(Collider other)
    {
        string action = other.gameObject.name;
        switch(action){
            case "boss":
                openpopup(task1);
                break;
            case "chairr":
                openpopup(task2);
                break;
            case "chair3":
                openpopup(task3);
                break;
            case "table":
                openpopup(task4);
                break;
            case "cabinet":
                openpopup(task5);
                break;
            case "board":
                openpopup(fun1);
                break;
            case "plant1":
                openpopup(fun2);
                break;
            case "door":
                openpopup(fun3);
                break;
            case "tableo":
                openpopup(fun4);
                break;
            case "planty":
                openpopup(fun5);
                break;
        }
    }
    public void openpopup(Sprite image){
        comics.sprite = image;
        popup.SetActive(true);
    }

    public void closepopup(){
        popup.SetActive(false);
    }
}
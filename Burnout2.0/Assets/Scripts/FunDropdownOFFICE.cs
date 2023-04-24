using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FunDropdownOFFICE : MonoBehaviour
{

    public GameObject FunLight, FunSpot;
    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();


        List<string> Fun = new List<string>();
        Fun.Add("Draw on whiteboard");
        Fun.Add("Play games on phone");
        Fun.Add("Step outside for a break");
        Fun.Add("Daydream");
        Fun.Add("Call friends");


        foreach (var item in Fun)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item});

        }

        ListsItemsSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate {ListsItemsSelected(dropdown); });
    }

    void ListsItemsSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        Debug.Log(index);
        switch (index)
        {
            case 0:
                FunLight.transform. position = new Vector3(6.5f, 10f, 1f);
                FunSpot.transform. position = new Vector3(6.5f, 1f, 1f);
                break;
            case 1:
                FunLight.transform. position = new Vector3(8.5f, 5f, -5f);
                FunSpot.transform. position = new Vector3(8.5f, 1f, -5f);
                break;
            case 2:
                FunLight.transform. position = new Vector3(9f, 5f, 1f);
                FunSpot.transform. position = new Vector3(9f, 1f, 1f);
                break;
            case 3:
                FunLight.transform. position = new Vector3(6f, 5f, -2f);
                FunSpot.transform. position = new Vector3(6f, 1f, -2f);
                break;
            case 4:
                FunLight.transform. position = new Vector3(6f, 5f, -4f);
                FunSpot.transform. position = new Vector3(6f, 1f, -2f);
                break;
            default:
                FunLight.transform. position = new Vector3(2f, 15f, 0f);
                FunSpot.transform. position = new Vector3(2f, 1f, 0f);
                break;
        }
    }
    
}
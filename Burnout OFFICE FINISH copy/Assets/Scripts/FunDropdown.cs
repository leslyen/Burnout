using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FunDropdown : MonoBehaviour
{

    public GameObject FunLight, FunSpot;
    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();


        List<string> Fun = new List<string>();
        Fun.Add("Read a personal book");
        Fun.Add("Eat with Friends");
        Fun.Add("Skip Class");
        Fun.Add("Daydream");
        Fun.Add("Plan a roadtrip");


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
                FunLight.transform. position = new Vector3(0f, 15f, -17f);
                FunSpot.transform. position = new Vector3(0f, 1f, -17f);
                break;
            case 1:
                FunLight.transform. position = new Vector3(17f, 15f, -21f);
                FunSpot.transform. position = new Vector3(17f, 1f, -21f);
                break;
            case 2:
                FunLight.transform. position = new Vector3(8.5f, 15f, 6.5f);
                FunSpot.transform. position = new Vector3(8.5f, 1f, 6.5f);
                break;
            case 3:
                FunLight.transform. position = new Vector3(24f, 15f, -31f);
                FunSpot.transform. position = new Vector3(24f, 1f, -31f);
                break;
            case 4:
                FunLight.transform. position = new Vector3(3f, 15f, -5f);
                FunSpot.transform. position = new Vector3(3f, 1f, -5f);
                break;
            default:
                FunLight.transform. position = new Vector3(2f, 15f, 0f);
                FunSpot.transform. position = new Vector3(2f, 1f, 0f);
                break;
        }
    }
    
}
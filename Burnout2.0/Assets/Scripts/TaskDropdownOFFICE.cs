using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskDropdownOFFICE : MonoBehaviour
{
    public GameObject TaskLight, TaskSpot;
    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        List<string> Tasks = new List<string>();
        Tasks.Add("Talk to boss");
        Tasks.Add("Ask for a raise");
        Tasks.Add("Talk to coworker");
        Tasks.Add("Do paperwork");
        Tasks.Add("Get coffee for coworkers");

        foreach (var item in Tasks)
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
                TaskLight.transform. position = new Vector3(9f, 10f, 1f);
                TaskSpot.transform. position = new Vector3(9f, 1f, 1f);
                break;
            case 1:
                TaskLight.transform. position = new Vector3(6f, 10f, 1f);
                TaskSpot.transform. position = new Vector3(6f, 1f, 1f);
                break;
            case 2:
                TaskLight.transform. position = new Vector3(6f, 5f, -2f);
                TaskSpot.transform. position = new Vector3(6f, 1f, -2f);
                break;
            case 3:
                TaskLight.transform. position = new Vector3(7.4f, 5f, -4f);
                TaskSpot.transform. position = new Vector3(7.4f, 1f, -4f);
                break;
            case 4:
                TaskLight.transform. position = new Vector3(9f, 5f, -5f);
                TaskSpot.transform. position = new Vector3(9f, 1f, -5f);
                break;
            default:
                TaskLight.transform. position = new Vector3(7f, 20f, -10f);
                TaskSpot.transform. position = new Vector3(7f, 1f, -10f);
                break;
        }
    }
    
}

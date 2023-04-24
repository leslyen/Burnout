using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskDropdown : MonoBehaviour
{
    public GameObject TaskLight, TaskSpot;
    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        List<string> Tasks = new List<string>();
        Tasks.Add("Do Homework");
        Tasks.Add("Take your math test");
        Tasks.Add("Go to lecture");
        Tasks.Add("Class presentation");
        Tasks.Add("Talk to advisor");

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
                TaskLight.transform. position = new Vector3(0f, 20f, -24f);
                TaskSpot.transform. position = new Vector3(0f, 1f, -24f);
                break;
            case 1:
                TaskLight.transform. position = new Vector3(3f, 20f, -10f);
                TaskSpot.transform. position = new Vector3(3f, 1f, -10f);
                break;
            case 2:
                TaskLight.transform. position = new Vector3(17f, 20f, 0f);
                TaskSpot.transform. position = new Vector3(17f, 1f, 0f);
                break;
            case 3:
                TaskLight.transform. position = new Vector3(-2f, 20f, -3f);
                TaskSpot.transform. position = new Vector3(-2f, 1f, -3f);
                break;
            case 4:
                TaskLight.transform. position = new Vector3(25f, 20f, -13f);
                TaskSpot.transform. position = new Vector3(25f, 1f, -13f);
                break;
            default:
                TaskLight.transform. position = new Vector3(7f, 20f, -10f);
                TaskSpot.transform. position = new Vector3(7f, 1f, -10f);
                break;
        }
    }
    
}
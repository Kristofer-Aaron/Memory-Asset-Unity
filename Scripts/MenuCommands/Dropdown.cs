using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dropdown : MonoBehaviour
{
    public void StateInputData(int val)
    {
        if (val == 0)
        {
            StateNameController.GridWidth = 4;
            StateNameController.GridHeight = 4;
            Debug.Log("Grid size set to 4x4");
        }
        if (val == 1)
        {
            StateNameController.GridWidth = 6;
            StateNameController.GridHeight = 4;
            Debug.Log("Grid size set to 6x4");
        }
        if (val == 2)
        {
            StateNameController.GridWidth = 6;
            StateNameController.GridHeight = 6;
            Debug.Log("Grid size set to 6x6");
        }
        if (val == 3)
        {
            StateNameController.GridWidth = 8;
            StateNameController.GridHeight = 6;
            Debug.Log("Grid size set to 8x6");
        }
    }
}

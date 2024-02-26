using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public int ActiveSlots = 0;
    public Transform Slots;
    public Transform[] InventorySlots;
    void Start()
    {
        InventorySlots = Slots.GetComponentsInChildren<Transform>();
        //Se activa Slots
        InventorySlots[ActiveSlots].GetChild(0).gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        InventorySlots[ActiveSlots].GetChild(0).gameObject.SetActive(true);
    }
}

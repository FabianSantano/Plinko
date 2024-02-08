using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public int points;
    public int slotNum;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Entered slot {slotNum} and got {points}");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory {
    public int[] inventory = new int[50];
    public bool testBool = true;
    public void initInventory()
    {
        for(int i = 0; i <= inventory.Length-1; i++)
        {
            inventory[i] = 0;
        }
    }

    public void addInventory(int id, int num)
    {
        inventory[id] = num;
    }

    public void removeInventory(int id)
    {
        inventory[id] = 0;
    }
}

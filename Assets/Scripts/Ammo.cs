using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] AmmoSlot[] ammoSlots;

    [System.Serializable]
    private class AmmoSlot
    {
        public AmmoType ammoType;
        public int ammoAmount;
    }
    
    public int GetCurrentAmmo(AmmoType ammotype)
    {
        return GetAmmoSlot(ammotype).ammoAmount;
    }

    public void IncreaseCurrentAmmo(AmmoType ammotype, int ammoAmount)
    {
        GetAmmoSlot(ammotype).ammoAmount += ammoAmount;
    }

    public void ReduceCurrentAmmo(AmmoType ammotype)
    {
        GetAmmoSlot(ammotype).ammoAmount--;
    }

    private AmmoSlot GetAmmoSlot(AmmoType ammoType)
    {
        foreach (AmmoSlot slot in ammoSlots)
        {
            if (slot.ammoType == ammoType)
            {
                return slot;
            }
        }
        return null;
    }
}

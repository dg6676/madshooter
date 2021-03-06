﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour {

    public Inventory inventory;
    public EquipmentPart handEquip;

    public Weapon currWeapon;

    // Use this for initialization
    void Start () {
        // Equip default weapon
        currWeapon = inventory.weapons[0];
        EquipWeapon(currWeapon);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void EquipWeapon(Weapon weapon)
    {
        handEquip.ChangeSprite(weapon.sprite);
        weapon.equipmentPart = handEquip;
    }
}

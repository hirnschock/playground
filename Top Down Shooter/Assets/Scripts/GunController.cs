using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    public Transform WeaponHold;
    public Gun startingGun;
    Gun equippedGun;

    void Start()
    {
        if (startingGun != null)
        {
            EquipGun(startingGun);
        }
    }

    public void EquipGun(Gun gunToEquip) {
        if (equippedGun != null)
        {
            Destroy(equippedGun.gameObject);
        }
        equippedGun = Instantiate(gunToEquip,WeaponHold.position,WeaponHold.rotation) as Gun;
        equippedGun.transform.parent = WeaponHold;
    }
}

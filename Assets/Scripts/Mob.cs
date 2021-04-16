using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public float speed;
    public Transform gunPrefab;
    public int gunCount;
    public List<Gun> guns = new List<Gun>();
    #region methods
    void Fire()
    {
        foreach (Gun gun in guns)
        {
            gun.OnFire();
        }
    }
    void spawnGun(int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            Transform asd = Instantiate(gunPrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, i * 20), transform);///creates the gun gameobject
            guns.Add(asd.GetComponent<Gun>());///assigns the gun script to the gun list

        }

    }

    #endregion
}

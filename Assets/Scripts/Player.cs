using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //cool spawn thing
        spawnGun(gunCount);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Fire();
        Bomb();
        Turn();
    }
    #region variables
    public float speed;
    public Transform gunPrefab;
    public int gunCount;
    public List<Gun> guns = new List<Gun>();
    #endregion
    #region methods
    void Movement()//move around
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
            Debug.Log("up");
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
            Debug.Log("down");
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            Debug.Log("left");
        }
        if (Input.GetKey("right"))
        {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
            Debug.Log("right");
        }
}
    void Fire()//shoot
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            foreach (Gun gun in guns)
            {
                gun.OnFire();
            }
        }
        
    }
    void Bomb()//clear screen
    {

    }
    void Turn()//turn left/right
    {

    }
    void spawnGun(int quantity)
    {
        for(int i=0;i<quantity;i++)
        {
            Transform asd = Instantiate(gunPrefab, transform.position,transform.rotation * Quaternion.Euler(0,0,i*20),transform);///creates the gun gameobject
            guns.Add(asd.GetComponent<Gun>());///assigns the gun script to the gun list

        }
        
    }
    #endregion

}

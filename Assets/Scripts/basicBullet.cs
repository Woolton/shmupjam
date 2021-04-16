using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicBullet : MonoBehaviour
{

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * shotSpeed);
    }
    #region variables
    public float shotSpeed = 5; 
    #endregion
}

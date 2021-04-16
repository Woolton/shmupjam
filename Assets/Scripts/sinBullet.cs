using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinBullet : MonoBehaviour
{

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * shotSpeed);
        transform.Translate(Vector2.up * Mathf.Sin(Time.deltaTime*.5f));
    }
    #region variables
    public float shotSpeed = 5;
    #endregion
}

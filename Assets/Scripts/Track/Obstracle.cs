using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstracle : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Player" && !Character.Invincible)
    {
      Character.Life--;
      if (Character.Life > 0) Character.Invincible = true;
    }
    if (other.gameObject.tag == "Coin")
    {
      if (this.gameObject.tag == "JumpObstracle") other.transform.position += Vector3.up * 3;
      if (this.gameObject.tag == "NoPassObstracle") Object.Destroy(other.gameObject);
    }
  }
}

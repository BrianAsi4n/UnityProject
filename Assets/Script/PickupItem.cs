using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    [SerializeField] PickupType pickupType;
    [SerializeField] float pickupValue;

   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.AddScore(1);
           switch (pickupType)
            {
                case PickupType.HP:
                    GameManager.Instance.AddHealth(pickupValue);
                    break;
                case PickupType.MP:
                    GameManager.Instance.AddMana(pickupValue);
                    break;
                case PickupType.Damage:
                    GameManager.Instance.AddDamage(pickupValue);
                    break;
            }

            Destroy(gameObject);
        }
    }
}
   public enum PickupType
{
    HP,MP,Damage
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Visitor_Pattern
{
    public class BikeController : MonoBehaviour
    {
        private const string PowerUpTag = "PowerUp";
        private BikeShield _shield;
        private BikeEngine _engine;
        private BikeWeapon _weapon;


        private void Start()
        {
            _shield = GetComponent<BikeShield>();
            _engine = GetComponent<BikeEngine>();
            _weapon = GetComponent<BikeWeapon>();
        }


        private void FetchThePowerUp(IVisitor visitor)
        {
            
                visitor.Visit(_shield);
                visitor.Visit(_engine);
                visitor.Visit(_weapon);
            
        }

        private void OnCollisionEnter(Collision other)
        {
            Debug.Log(other.gameObject.tag);
            if (!other.collider.gameObject.CompareTag(PowerUpTag)) return;
            var attachedPowerUpHolder = other.gameObject.GetComponent<PowrUpHolder>();
            FetchThePowerUp(attachedPowerUpHolder.attchedPowerup);
        }
    }
}

using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public abstract class Item : ScriptableObject
    {
        public int GUID;
        public string Name;
        public Sprite sprite;
    }
    public class Weapon : Item
    {
        public int Damage;
    }
    public class Armor : Item
    {
        public int AC;
    }


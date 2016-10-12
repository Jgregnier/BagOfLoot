using System;
using System.Collections.Generic;
using BoxOfLoot.Children;

namespace BoxOfLoot.Bags
{
    public class Bag
    {
        List<Child> DeliveryBag = new List<Child>();

        public void Add (string childName, string toyName)
        {
            Child newChild = new Child()
            {
                name = childName,
                toy = toyName
            };
            DeliveryBag.Add(newChild);
        }

        public void listChildren()
        {
            foreach (Child child in DeliveryBag)
            {
                Console.WriteLine($"{child.name} {child.toy}");
            }
        }

        public void removeChild(string childName)
        {
            for (var i = 0; i < DeliveryBag.Count; i++)
            {
                if(DeliveryBag[i].name == childName)
                {
                    DeliveryBag.Remove(DeliveryBag[i]);
                }
            }
        }
    }
}

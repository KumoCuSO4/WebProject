using System.Collections;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public void Print()
    {
        Person p = new Person()
        {
            Name = "nameeee",
            Age = 1,
            Height = 1,
        };

        p.Item.Add(1);

        Debug.Log(p.Name + p.Age + p.Height + p.Item[0]);
    }
}
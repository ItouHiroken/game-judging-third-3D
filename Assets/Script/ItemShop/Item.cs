using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    /// <summary>アイテムの ID</summary>
    public int Id;
    /// <summary>アイテムの名前</summary>
    public string Name;
    /// <summary>アイテムの値段</summary>
    public int Price;
    /// <summary>攻撃力</summary>
    public int Attack;
    /// <summary>防御力</summary>
    public int Defence;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public Item(int id, string name, int price, int attack, int defence)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        this.Attack = attack;
        this.Defence = defence;
    }
}

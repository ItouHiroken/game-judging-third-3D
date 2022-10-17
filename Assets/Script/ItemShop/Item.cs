using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    /// <summary>�A�C�e���� ID</summary>
    public int Id;
    /// <summary>�A�C�e���̖��O</summary>
    public string Name;
    /// <summary>�A�C�e���̒l�i</summary>
    public int Price;
    /// <summary>�U����</summary>
    public int Attack;
    /// <summary>�h���</summary>
    public int Defence;

    /// <summary>
    /// �R���X�g���N�^
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//　Lesson4 課題
public class test : MonoBehaviour
{
    
    void Start()
    {
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int j = 4; j >=0; j--)
        {
            Debug.Log(array[j]);
        }

        {

            Boss lastboss = new Boss();


            lastboss.Attack();

            lastboss.Defence(3);

            lastboss.Magic(5);
           
        }

         

    }
}

public class Boss
{
    private int hp = 100; 
    private int power = 25;
    private int mp = 53;

    
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

   
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        
        this.hp -= damage;
    }

    public void Magic(int mana)
    {

        for (int i = 0; i <= 10; i++)
        {

            if (mp >= 5)
            {
                this.mp -= mana;
                Debug.Log("魔法攻撃をした。残りMPは" + mp);

            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }
}
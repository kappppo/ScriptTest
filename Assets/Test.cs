using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   // 体力
    private int mp = 53;   // MP
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // MP消費の攻撃
    public void Magic()
    {
        int point = 5;
        if(mp >= point)
        {
            // MPを消費し、メッセージを表示
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }


}

public class Test : MonoBehaviour
{

    void Start()
    {
        // array配列を作成し、初期化
        int[] array = { 10, 20, 30, 40, 50 };

        // 昇順で出力
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 降順で出力
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[array.Length - (i + 1)]);
        }

        // 発展課題
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // Magic関数を呼び出して、魔法を使用
        lastboss.Magic();

        // Magic関数を10回連続で使用（最後にMP不足）
        for(int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

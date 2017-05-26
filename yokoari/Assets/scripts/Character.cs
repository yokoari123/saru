/* 遊び
 * Inspectorの変更
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;      //!< デプロイ時にEditorスクリプトが入るとエラーになるので UNITY_EDITOR で括ってね！
#endif

/**
 * キャラクタサンプルクラス
 */
public class Character : MonoBehaviour
{
    //! 体力
    [SerializeField]
    int m_hp_now = 100;                          //!< 現在値
    [SerializeField]
    int m_hp_max = 100;                          //!< 最大値

    [SerializeField]
    float m_spd = 6.4f;                         //!< 移動速度

    [SerializeField]
    string m_name = "星宮";                     //!< キャラ名

    [SerializeField]
    List<GameObject> m_friends = new List<GameObject>();       //!< 友達リスト


    //! 手法2の場合はプライベートメンバーにも直接アクセス可能なので、getter/setterは必須ではないよ！
    public int hp { get { return m_hp_now; } set { m_hp_now = value; } }
    public int maxHp { get { return m_hp_max; } set { m_hp_max = value; } }
    public float speed { get { return m_spd; } set { m_spd = value; } }
    public string charaName { get { return m_name; } set { m_name = value; } }
    public List<GameObject> friends { get { return m_friends; } set { m_friends = value; } }



    /* ---- ここから拡張コード ---- */
#if UNITY_EDITOR
    /**
     * Inspector拡張クラス
     */
    [CustomEditor(typeof(Character))]               //!< 拡張するときのお決まりとして書いてね
    public class CharacterEditor : Editor           //!< Editorを継承するよ！
    {
        bool folding = false;

        public override void OnInspectorGUI()
        {
            // target は処理コードのインスタンスだよ！ 処理コードの型でキャストして使ってね！
            Character chara = target as Character;

            /* -- カスタム表示 -- */

            // -- 体力 --
            EditorGUILayout.LabelField("体力(現在/最大)");
            EditorGUILayout.BeginHorizontal();
            chara.m_hp_now = EditorGUILayout.IntField(chara.m_hp_now, GUILayout.Width(48));
            chara.m_hp_max = EditorGUILayout.IntField(chara.m_hp_max, GUILayout.Width(48));
            EditorGUILayout.EndHorizontal();

            // -- 速度 --
            chara.m_spd = EditorGUILayout.FloatField("速度", chara.m_spd);

            // -- 名前 --
            chara.m_name = EditorGUILayout.TextField("名前", chara.m_name);

            // -- 友達 --
            List<GameObject> list = chara.m_friends;
            int i, len = list.Count;

            // 折りたたみ表示
            if (folding = EditorGUILayout.Foldout(folding, "友達"))
            {
                // リスト表示
                for (i = 0; i < len; ++i)
                {
                    list[i] = EditorGUILayout.ObjectField(list[i], typeof(GameObject), true) as GameObject;
                }

                GameObject go = EditorGUILayout.ObjectField("追加", null, typeof(GameObject), true) as GameObject;
                if (go != null)
                    list.Add(go);
            }
        }
    }
#endif
}
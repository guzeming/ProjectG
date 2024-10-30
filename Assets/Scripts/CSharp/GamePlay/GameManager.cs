using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public Texture2D customMouseIcon;
    
    // Start is called before the first frame update
    void Start()
    {
        // 设置自定义鼠标图标
        Cursor.SetCursor(customMouseIcon, new Vector2(customMouseIcon.width / 2, customMouseIcon.height / 2), CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 在编辑器中停止运行游戏
            #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
            #else
                           // 在构建后的游戏中退出
                           Application.Quit();
            #endif
        }
        
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            if (Cursor.visible)
            {
                Cursor.visible = false;
            }
            else
            {
                Cursor.visible = true;
            }
        }
    }
}

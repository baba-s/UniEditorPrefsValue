# UniEditorPrefsValue

EditorPrefs に関するコードを記述しやすくするクラス

## 使用例

### 通常

```cs
using UnityEditor;
using UnityEngine;

public class Example
{
    private const string KEY = "Hoge";

    [MenuItem( "Tools/Load" )]
    private static void Load()
    {
        Debug.Log( EditorPrefs.GetString( KEY ) );
    }

    [MenuItem( "Tools/Save" )]
    private static void Save()
    {
        EditorPrefs.SetString( KEY, "ピカチュウ" );
    }
}
```

### UniEditorPrefsValue

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

public class Example
{
    private static readonly EditorPrefsString m_value = new EditorPrefsString( "Hoge" );

    [MenuItem( "Tools/Load" )]
    private static void Load()
    {
        Debug.Log( m_value.Get() );
    }

    [MenuItem( "Tools/Save" )]
    private static void Save()
    {
        m_value.Set( "ピカチュウ" );
    }
}
```

* 用意されているクラスは以下の通り
    * EditorPrefsBool
    * EditorPrefsFloat
    * EditorPrefsInt
    * EditorPrefsString

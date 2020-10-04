using UnityEditor;

namespace Kogane
{
	public abstract class EditorPrefsValueBase<T> : IEditorPrefsValue<T>
	{
		public string Key          { get; }
		public T      DefaultValue { get; }

		protected EditorPrefsValueBase( string key, T defaultValue )
		{
			Key          = key;
			DefaultValue = defaultValue;
		}

		public abstract T Get( T defaultValue );

		public T Get()
		{
			return Get( DefaultValue );
		}

		public abstract void Set( T value );

		public bool Has()
		{
			return EditorPrefs.HasKey( Key );
		}

		public void Delete()
		{
			EditorPrefs.DeleteKey( Key );
		}
	}
}
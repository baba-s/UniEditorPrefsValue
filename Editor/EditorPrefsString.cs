using UnityEditor;

namespace Kogane
{
	public sealed class EditorPrefsString : EditorPrefsValueBase<string>
	{
		public EditorPrefsString( string key, string defaultValue )
			: base( key, defaultValue )
		{
		}

		public EditorPrefsString( string key ) : this( key, default )
		{
		}

		public override string Get( string defaultValue )
		{
			return EditorPrefs.GetString( Key, defaultValue );
		}

		public override void Set( string value )
		{
			EditorPrefs.SetString( Key, value );
		}
	}
}
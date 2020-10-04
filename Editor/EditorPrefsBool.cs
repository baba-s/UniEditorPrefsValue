using UnityEditor;

namespace Kogane
{
	public sealed class EditorPrefsBool : EditorPrefsValueBase<bool>
	{
		public EditorPrefsBool( string key, bool defaultValue )
			: base( key, defaultValue )
		{
		}

		public EditorPrefsBool( string key ) : this( key, default )
		{
		}

		public override bool Get( bool defaultValue )
		{
			return EditorPrefs.GetBool( Key, defaultValue );
		}

		public override void Set( bool value )
		{
			EditorPrefs.SetBool( Key, value );
		}
	}
}
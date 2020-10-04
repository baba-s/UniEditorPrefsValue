using UnityEditor;

namespace Kogane
{
	public sealed class EditorPrefsInt : EditorPrefsValueBase<int>
	{
		public EditorPrefsInt( string key, int defaultValue )
			: base( key, defaultValue )
		{
		}

		public EditorPrefsInt( string key ) : this( key, default )
		{
		}

		public override int Get( int defaultValue )
		{
			return EditorPrefs.GetInt( Key, defaultValue );
		}

		public override void Set( int value )
		{
			EditorPrefs.SetInt( Key, value );
		}
	}
}
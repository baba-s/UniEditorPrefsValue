using UnityEditor;

namespace Kogane
{
	public sealed class EditorPrefsFloat : EditorPrefsValueBase<float>
	{
		public EditorPrefsFloat( string key, float defaultValue )
			: base( key, defaultValue )
		{
		}

		public EditorPrefsFloat( string key ) : this( key, default )
		{
		}

		public override float Get( float defaultValue )
		{
			return EditorPrefs.GetFloat( Key, defaultValue );
		}

		public override void Set( float value )
		{
			EditorPrefs.SetFloat( Key, value );
		}
	}
}
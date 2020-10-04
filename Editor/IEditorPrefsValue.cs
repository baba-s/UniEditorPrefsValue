namespace Kogane
{
	public interface IEditorPrefsValue<T>
	{
		string Key          { get; }
		T      DefaultValue { get; }

		T    Get( T defaultValue );
		T    Get();
		void Set( T value );
		bool Has();
		void Delete();
	}
}
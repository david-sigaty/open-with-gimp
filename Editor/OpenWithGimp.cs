using UnityEditor;
using TeamCitrus.Editor;

public class OpenWithGimp : OpenWithMenuItem
{
	public const string Name = "GIMP";
	public const string Key = BaseKey + Name;
	private const string MenuItemPath = BasePath + Name;
	
	[MenuItem(MenuItemPath, false, BasePriority + 51)]
	public static void Open() { Execute<OpenWithGimp>(); }

	[MenuItem(MenuItemPath, true)]
	public static bool OpenValidation() { return Validate<OpenWithGimp>(); }
}

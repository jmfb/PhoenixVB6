using System.IO;

namespace PhoenixVB6
{
	public interface IFileSystem
	{
		Stream Open(string path, FileMode mode, FileAccess access, FileShare share);
	}
}
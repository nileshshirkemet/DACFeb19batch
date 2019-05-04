#include "legacy/include/box.h"

namespace Ijw
{
	public ref class LegacyBox
	{
	public:
		LegacyBox(long l, long b, long h)
		{
			length = l;
			breadth = b;
			height = h;
		}

		long GetInnerVolume(long thickness)
		{
			return BoxVolume(length, breadth, height, thickness);
		}	
	private:
		long length, breadth, height;
	};
}

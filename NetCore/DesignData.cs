using System;

namespace NetCore
{
	internal class NestedClass
	{
		public String AProperty { get; set; }
	}

	internal class DesignData
	{
		public String AProperty { get; set; }
		public NestedClass Nested { get; set; }

		public DesignData()
		{
			AProperty = "Root value";

			Nested = new NestedClass
			{
				AProperty = "Nested value",
			};
		}
	}
}

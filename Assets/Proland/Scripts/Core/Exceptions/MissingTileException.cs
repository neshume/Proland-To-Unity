﻿
using System;

namespace Proland
{
	
	public class MissingTileException : ProlandException
	{
		public MissingTileException()
		{
			
		}
		
		public MissingTileException(string message)
			: base(message)
		{
			
		}
		
		public MissingTileException(string message, Exception inner)
			: base(message, inner)
		{
			
		}
	}
	
}

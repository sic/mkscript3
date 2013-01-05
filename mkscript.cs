using System;

namespace mkscript3
{
	/// <summary>
	/// Summary description for mkscipt.
	/// </summary>
	public class mkscript
	{
		static float version = 7.0F;
		static string name = "MKSCRIPT";
		public float a = 1.823F;	
		
		public mkscript()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Displays version information 
		/// </summary>
		/// <returns></returns>
		public String PrintVersion()
		{
			return "'"+name+"', 'vers "+version.ToString()+"'";
		}
	
	

	}
}

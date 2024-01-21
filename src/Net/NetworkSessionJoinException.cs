﻿#region License
/* FNA.Steamworks - XNA4 Xbox Live Reimplementation for Steamworks
 * Copyright 2016 Ethan "flibitijibibo" Lee
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

#region Using Statements
using System;
using System.Runtime.Serialization;

using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace Microsoft.Xna.Framework.Net
{
	public class NetworkSessionJoinException : NetworkException
	{
		#region Public Properties

		public NetworkSessionJoinError JoinError
		{
			get;
			set;
		}

		#endregion

		#region Public Constructors

		public NetworkSessionJoinException() : base()
		{
		}

		public NetworkSessionJoinException(string message) : base(message)
		{
		}

		public NetworkSessionJoinException(
			string message,
			NetworkSessionJoinError joinError
		) : base(message) {
			JoinError = joinError;
		}

		public NetworkSessionJoinException(
			string message,
			Exception innerException
		) : base(message, innerException) {
		}

		#endregion

		#region Protected Constructor

		[Obsolete("Obsolete")]
		protected NetworkSessionJoinException(
			SerializationInfo info,
			StreamingContext context
		) : base(info, context) {
		}

		#endregion
	}
}

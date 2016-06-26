﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatEventArgs.cs" company="Flush Arcade Pty Ltd.">
//   Copyright (c) 2015 Flush Arcade Pty Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Chat.Common.Events
{
	using System;

	using Chat.Common.Model;

	public class ChatEventArgs : EventArgs
	{
		public string Message { private set; get; }

		public ChatEventArgs(string message)
		{
			Message = message;
		}
	}
}
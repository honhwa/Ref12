﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLaks.Ref12
{
	internal sealed partial class Vsix
	{
		public const string Id = "SLaks-Ref12-086C4CE4-7061-4B1F-BC77-B64E4ED71B8E";
		public const string Name = "Ref12";
		public const string Description = @"Forwards F12 to source code instead of showing metadata.";
		public const string Language = "en-US";
		public const string Version = "4.6.1";
		public const string Author = "SLaks";
		public const string Tags = "C#, VB.Net, Reference Source, Source, Roslyn";

		public const string GuidExtensionPackageString = "7E85FEAF-1785-4BE8-8E0C-0B4C55A97851";
		public const string GuidCommandIDString = "BD27207E-0A63-4C87-A111-D226F1C22EE3";
		public static readonly Guid GuidCommandID = new Guid(GuidCommandIDString);
	}
}

﻿/***************************************************************************************************
 *
 *  TaskDialog Library
 *  Copyright © 2014 Florian Schneidereit. All Rights Reserved.
 *
 *  File:
 *    AssemblyInfo.cs
 *  Purpose:
 *    Assembly attributes.
 *  Authors:
 *    Florian Schneidereit <florian.schneidereit@outlook.com>
 *
 *  This library is free software; you can redistribute it and/or modify it under the terms of
 *  the GNU Lesser General Public License as published by the Free Software Foundation; either
 *  version 2.1 of the License, or (at your option) any later version.
 *
 *  This library is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 *  without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 *  See the GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public License along with this
 *  library; if not, write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
 *  Boston, MA  02110-1301  USA
 *
 **************************************************************************************************/

#region Using Directives

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Markup;

#endregion

// General attributes
[assembly: AssemblyTitle("TaskDialogLib")]
[assembly: AssemblyDescription("TaskDialogLib")]
[assembly: AssemblyProduct("TaskDialogLib")]
[assembly: AssemblyCopyright("Copyright © 2014 Florian Schneidereit")]

// Configuration attributes
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

// Presentation attributes
[assembly: XmlnsDefinition("http://github.com/sevenacids/TaskDialogLib", "TaskDialogLib")]
[assembly: XmlnsPrefix("http://github.com/sevenacids/TaskDialogLib", "tdl")]

// Versioning attributes
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0")]

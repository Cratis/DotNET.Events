/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace Cratis.Events
{
	/// <summary>
	/// The exception that is thrown when an <see cref="IEvent"/> is out of sequence in an <see cref="EventStream"/>
	/// </summary>
    public class EventOutOfSequenceException : ArgumentException
    {
    }
}

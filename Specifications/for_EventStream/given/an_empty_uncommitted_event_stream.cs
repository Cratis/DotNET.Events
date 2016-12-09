﻿using System;
using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream.given
{
    public abstract class an_empty_uncommitted_event_stream
    {
        protected static UncommittedEventStream EventStream;
        protected static Guid EventSourceId;

        Establish context = () =>
                {
                    EventSourceId = Guid.NewGuid();
                    EventStream = new UncommittedEventStream(EventSourceId);
                };
    }
}
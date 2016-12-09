using System;
using Cratis.Events;
using Cratis.Events.Specs.behaviors;
using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream
{
    public class when_appending_an_event_to_an_uncommitted_event_stream : given.an_empty_uncommitted_event_stream
    {
        static IEvent Event;

        Establish context =
            () =>
                {
                    Event = new SimpleEvent(EventStream.EventSourceId);
                };

        Because of = () => EventStream.Append(Event);

#pragma warning disable 0169
        Behaves_like<an_event_stream_with_one_event_appended> an_event_stream;
#pragma warning restore 0169        

    }
}
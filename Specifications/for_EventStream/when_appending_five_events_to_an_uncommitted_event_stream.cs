using System.Collections.Generic;
using Cratis.Events;
using Cratis.Events.Specs.for_EventStream.behaviors;
using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream
{
    public class when_appending_five_events_to_an_uncommitted_event_stream : given.an_empty_uncommitted_event_stream
    {
        static List<IEvent> Events ;

        Establish context =
            () =>
                {
                    Events = new List<IEvent>();
                    for (var i = 0; i < 5; i++ )
                    {
                        Events.Add(new SimpleEvent(EventSourceId));
                    }
                };

        Because of = () =>
                                 {
                                     foreach (var @event in Events)
                                     {
                                         EventStream.Append(@event);
                                     }

                                 };
#pragma warning disable 0169
        Behaves_like<an_event_stream_with_five_events_appended> an_event_stream;
#pragma warning restore 0169        

    }
}
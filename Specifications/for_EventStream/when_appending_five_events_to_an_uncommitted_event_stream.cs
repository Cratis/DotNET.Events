using System.Collections.Generic;
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
        It should_have_events = () => EventStream.HasEvents.ShouldBeTrue();
        It should_have_an_event_count_of_5 = () => EventStream.Count.ShouldEqual(5);
    }
}
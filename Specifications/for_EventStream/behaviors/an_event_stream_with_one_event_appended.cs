using Cratis.Events.Specs.for_EventStream.given;
using Machine.Specifications;

namespace Cratis.Events.Specs.behaviors
{
    [Behaviors]
    public class an_event_stream_with_one_event_appended
    {
        protected static EventStream EventStream;

        private It should_have_events = () => EventStream.HasEvents.ShouldBeTrue();
        private It should_have_an_event_count_of_1 = () => EventStream.Count.ShouldEqual(1);
    }
}
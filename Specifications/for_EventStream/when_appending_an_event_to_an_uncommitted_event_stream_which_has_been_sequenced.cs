using System;
using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream
{
    public class when_appending_an_event_to_an_uncommitted_event_stream_which_has_been_sequenced
        : given.an_empty_uncommitted_event_stream
    {
        static Exception Exception;

        Because of = () =>
                         {
                             var sequencedEvent = new SimpleEvent(Guid.NewGuid());
                             Exception = Catch.Exception(() => EventStream.Append(sequencedEvent));
                         };

        It should_throw_an_exception = () => Exception.ShouldNotBeNull();
    }
}
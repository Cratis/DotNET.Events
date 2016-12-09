using System;
using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream
{
    public class when_appending_an_event_to_an_uncommitted_event_stream_which_has_been_attached_to_an_event_source
        : given.an_empty_uncommitted_event_stream
    {
        static Exception Exception;

        Because of = () =>
        {
            var attachedEvent = new SimpleEvent(Guid.NewGuid());
            Exception = Catch.Exception(() => EventStream.Append(attachedEvent));
        };

        It should_throw_an_exception = () => Exception.ShouldNotBeNull();
    }
}
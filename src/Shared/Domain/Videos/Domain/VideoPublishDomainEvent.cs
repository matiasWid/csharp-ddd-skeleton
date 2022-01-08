using System;
using System.Collections.Generic;
using System.Text;
using CodelyTv.Shared.Domain.Bus.Event;

namespace CodelyTv.Shared.Domain.Videos.Domain
{
    public class VideoPublishDomainEvent : DomainEvent
    {
        public string Type { get; }
        public string Title { get; }
        public Uri Url { get; }
        public Guid CourseId { get; }

        public VideoPublishDomainEvent()
        {
        }

        public VideoPublishDomainEvent(string id, string type,
            string title, Uri url, Guid courseId,
            string eventId = null, string occurredOn = null) : base (id, eventId, occurredOn)
        {
            Type = type;
            Title = title;
            Url = url;
            CourseId = courseId;
        }

        public override string EventName()
        {
            return "video.uploaded";
        }

        public override DomainEvent FromPrimitives(string aggregateId, Dictionary<string, string> body, string eventId, string occurredOn)
        {
            return new VideoPublishDomainEvent(aggregateId,
                body["type"],
                body["title"],
                new Uri(body["url"]),
                new Guid(body["courseId"]),
                eventId,
                occurredOn);
        }

        public override Dictionary<string, string> ToPrimitives()
        {
            return new Dictionary<string, string>
            {
                { "type",       Type },
                { "title",      Title },
                { "url",        Url.AbsolutePath },
                { "courseId",   CourseId.ToString() }
            };
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as VideoPublishDomainEvent;
            if (item == null) return false;

            return
                string.Equals(AggregateId, item.AggregateId, StringComparison.InvariantCulture) &&
                string.Equals(Type, item.Type, StringComparison.InvariantCulture) &&
                string.Equals(Title, item.Title, StringComparison.InvariantCulture) &&
                Uri.Equals(Url, item.Url) && Guid.Equals(CourseId, item.CourseId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AggregateId, Type, Title, Url.AbsolutePath, CourseId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using CodelyTv.Mooc.Shared.Domain;
using CodelyTv.Shared.Domain.Aggregate;
using CodelyTv.Shared.Domain.Videos.Domain;

namespace CodelyTv.Mooc.Videos.Domain
{
    public class Video: AggregateRoot
    {
        public VideoId Id { get;}
        public VideoType Type { get;}
        public VideoTitle Title { get;}
        public VideoUrl Url { get;}
        public CourseId CourseId { get;}
        public Video(VideoId id, VideoType type, VideoTitle title, VideoUrl url, CourseId courseId)
        {
            Id = id;
            Type = type;
            Title = title;
            Url = url;
            CourseId = courseId;
        }

        public static Video Create(VideoId id, VideoType type, VideoTitle title, VideoUrl url, CourseId courseId)
        {
            var video = new Video(id, type, title, url, courseId);

            video.Record(
                new VideoPublishDomainEvent(id.Value, type.Value, title.Value,
                new Uri(url.Value), new Guid(courseId.Value)));

            return video;
        }
    }
}

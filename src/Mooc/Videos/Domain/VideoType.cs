using System.Collections.Generic;
using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Videos.Domain
{
    public class VideoType: Enum
    {

        public const string SCREENCAST = "screencast";
        public const string INTERVIEW = "interview";
        
        public VideoType(string value) : base(value)
        {
        }
    }
}

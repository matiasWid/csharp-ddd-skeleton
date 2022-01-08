using System;
using System.Collections.Generic;
using System.Text;
using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Videos.Domain
{
    public class VideoId : Uuid
    {
        public VideoId(string value) : base(value)
        {
        }
    }
}

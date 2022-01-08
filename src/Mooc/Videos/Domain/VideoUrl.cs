using System;
using System.Collections.Generic;
using System.Text;
using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Videos.Domain
{
    public class VideoUrl : StringValueObject
    {
        public VideoUrl(string value) : base(value)
        {
        }
    }
}

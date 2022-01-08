using System;
using System.Collections.Generic;
using System.Text;
using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Videos.Domain
{
    public class VideoTitle : StringValueObject
    {
        public VideoTitle(string value) : base(value)
        {
        }
    }
}

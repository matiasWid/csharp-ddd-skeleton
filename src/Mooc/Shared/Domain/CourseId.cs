using System;
using System.Collections.Generic;
using System.Text;
using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Shared.Domain
{
    public class CourseId : Uuid
    {
        public CourseId(string value) : base(value)
        {
        }
    }
}

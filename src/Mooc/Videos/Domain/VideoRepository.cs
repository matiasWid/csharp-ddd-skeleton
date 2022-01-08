using System;
using System.Collections.Generic;
using System.Text;

namespace CodelyTv.Mooc.Videos.Domain
{
    internal interface VideoRepository
    {
        public void save(Video video);
    }
}

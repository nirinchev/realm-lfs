﻿using System;
using Realms;
using Realms.LFS;

namespace Shared
{
    public class FeedUser : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte[] ProfilePicture { get; set; }

        public FileData ProfilePictureData { get; set; }
    }
}

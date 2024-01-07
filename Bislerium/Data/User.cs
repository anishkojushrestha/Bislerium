﻿namespace Bislerium.Data
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Password { get; set; }
        public Role role { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

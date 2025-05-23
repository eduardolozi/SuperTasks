﻿namespace SuperTasks.Domain.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Task> Tasks { get; set; } = [];
}
﻿namespace SuperTasks.Domain.Models;

public class Task
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public TimeSpan Duration { get; set; }
    public List<User> Users { get; set; } = [];
}
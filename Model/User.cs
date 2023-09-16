﻿namespace UserManagerApp.Model;

public class User
{
    public Guid Id { get; init; }
    public string Login { get; init; }
    public string Password { get; init; }
    public string Email { get; init; }
}

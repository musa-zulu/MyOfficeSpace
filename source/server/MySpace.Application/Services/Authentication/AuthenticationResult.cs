using MySpace.Domain.Entities;

namespace MySpace.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);
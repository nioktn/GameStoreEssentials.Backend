using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Features.Games.UpdateGame;

public record UpdateGameDto(
    [Required] [MaxLength(128)] string Name,
    Guid GenreId,
    [Range(1, 100)] decimal Price,
    DateOnly ReleaseDate,
    [MaxLength(1024)] string Description);
using GameStore.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Features.Games.UpdateGame;

public static class UpdateGameEndpoint
{
    public static void MapUpdateGame(this IEndpointRouteBuilder app)
    {
        // PUT /games/122233-434d-43434...
        app.MapPut("/{id:guid}", async (Guid id, UpdateGameDto gameDto, GameStoreContext dbContext) =>
            {
                var existingGame = await dbContext.Games.FindAsync(id);

                if (existingGame is null)
                {
                    return Results.NotFound();
                }

                existingGame.Name = gameDto.Name;
                existingGame.GenreId = gameDto.GenreId;
                existingGame.Price = gameDto.Price;
                existingGame.ReleaseDate = gameDto.ReleaseDate;
                existingGame.Description = gameDto.Description;

                await dbContext.SaveChangesAsync();

                return Results.NoContent();
            })
            .WithParameterValidation();
    }
}
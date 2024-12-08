using GameStore.Api.Models;

namespace GameStore.Api.Data;

public class GameStoreData
{
    private readonly List<Genre> _genres =
    [
        new() { Id = new Guid("7BC5E1BD-26D0-4C8B-A1EA-21058372CF5C"), Name = "Fighting" },
        new() { Id = new Guid("C83D6CC7-29ED-4A27-951C-7C079A58B30A"), Name = "Roleplaying" },
        new() { Id = new Guid("55936564-74AF-40C1-A46D-58CA9CE08D59"), Name = "Sports" },
        new() { Id = new Guid("ADDED5D9-7E9C-43B7-8F41-3C812FFFE20E"), Name = "Racing" },
        new() { Id = new Guid("B1E2D3A8-0FCF-4D4A-8CDB-A782DDA56DA0"), Name = "Kids and Family" }
    ];

    private readonly List<Game> _games;

    public GameStoreData()
    {
        _games =
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Street Fighter II",
                Genre = _genres[0],
                GenreId = _genres[0].Id,
                Price = 19.99m,
                ReleaseDate = new DateOnly(1992, 7, 15),
                Description =
                    "Street Fighter II: The World Warrior[b] is a 1991 fighting game produced by Capcom for arcades, and their fourteenth game to use the CP System arcade system board. It is the second installment in the Street Fighter series and the sequel to 1987's Street Fighter. Street Fighter II vastly improved many of the concepts introduced in the first game, including the use of special command-based moves, a combo system, a six-button configuration, and a wider selection of playable characters, each with a unique fighting style."
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Final Fantasy XIV",
                Genre = _genres[1],
                GenreId = _genres[1].Id,
                Price = 59.99m,
                ReleaseDate = new DateOnly(2010, 9, 30),
                Description =
                    "Final Fantasy XIV[c] is a massively multiplayer online role-playing game (MMORPG) developed and published by Square Enix. Directed and produced by Naoki Yoshida and released worldwide for PlayStation 3 and Windows in August 2013, it replaced the failed 2010 version, with subsequent support for PlayStation 4, macOS, PlayStation 5, and Xbox Series X/S. Final Fantasy XIV is set in the fantasy region of Eorzea, five years after the devastating Seventh Umbral Calamity which ended the original version. In the Calamity, the elder primal Bahamut escaped from his prison, an ancient space station called Dalamud, unleashing an apocalypse across Eorzea. Through temporal magic, the player character of the original version escaped, reappearing at the start of A Realm Reborn. As Eorzea cements its recovery, the player must fend off a reignited invasion from the Garlean Empire."
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "FIFA 23",
                Genre = _genres[2],
                GenreId = _genres[2].Id,
                Price = 69.99m,
                ReleaseDate = new DateOnly(2022, 9, 27),
                Description =
                    "FIFA 23 is a football video game published by EA Sports. It is the 30th and final installment in the FIFA series that is developed by EA Sports, and released worldwide on 30 September 2022 for Nintendo Switch, PlayStation 4, PlayStation 5, Windows, Xbox One and Xbox Series X/S.[2]"
            }
        ];
    }

    public IEnumerable<Game> GetGames() => _games;
    public Game? GetGame(Guid id) => _games.Find(game => game.Id == id);

    public void AddGame(Game game)
    {
        game.Id = Guid.NewGuid();
        _games.Add(game);
    }

    public void RemoveGame(Guid id)
    {
        _games.RemoveAll(game => game.Id == id);
    }

    public IEnumerable<Genre> GetGenres() => _genres;
    public Genre? GetGenre(Guid id) => _genres.Find(genre => genre.Id == id);
}
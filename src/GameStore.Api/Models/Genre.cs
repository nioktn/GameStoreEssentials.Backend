using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Models;

public class Genre
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
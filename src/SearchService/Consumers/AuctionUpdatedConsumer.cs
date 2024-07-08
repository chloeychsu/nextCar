using AutoMapper;
using Contracts;
using MassTransit;
using MongoDB.Entities;
using SearchService.Models;

namespace SearchService;

public class AuctionUpdatedConsumer : IConsumer<AuctionUpdated>
{
    public async Task Consume(ConsumeContext<AuctionUpdated> context)
    {
        Console.WriteLine("--> Consuming auction updated: " + context.Message.Id);

        await DB.Update<Item>()
        .MatchID(context.Message.Id)
        .Modify(x => x.Make, context.Message.Make)
        .Modify(x => x.Model, context.Message.Model)
        .Modify(x => x.Year, context.Message.Year)
        .Modify(x => x.Color, context.Message.Color)
        .Modify(x => x.Mileage, context.Message.Mileage)
        .ExecuteAsync();
    }
}

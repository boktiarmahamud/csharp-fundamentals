using Minimal_APIs.Data;
using Minimal_APIs.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/api/coupons", () =>
{
    return Results.Ok(CuponStore.cuponList);
});

app.MapGet("/api/coupons/{id:int}", (int id) =>
{
    var coupon = CuponStore.cuponList
        .FirstOrDefault(c => c.Id == id);

    if (coupon == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(coupon);
});

app.MapPost("/api/coupons", (Cupon coupon) =>
{
    coupon.Id = CuponStore.cuponList.Max(c => c.Id) + 1;
    coupon.Created = DateTime.Now;
    coupon.LastUpdated = DateTime.Now;

    CuponStore.cuponList.Add(coupon);
    return Results.Created(
       $"/api/coupons/{coupon.Id}",
       coupon
   );

});

app.MapPut("/api/coupons/{id:int}", (int id, Cupon updatedCoupon) =>
{
    var coupon = CuponStore.cuponList
        .FirstOrDefault(c => c.Id == id);

    if (coupon == null)
    {
        return Results.NotFound();
    }

    coupon.Name = updatedCoupon.Name;
    coupon.Percent = updatedCoupon.Percent;
    coupon.IsActive = updatedCoupon.IsActive;
    coupon.LastUpdated = DateTime.Now;

    return Results.Ok(coupon);
});

app.MapDelete("/api/coupons/{id:int}", (int id) =>
{
    var coupon = CuponStore.cuponList
        .FirstOrDefault(c => c.Id == id);

    if (coupon == null)
    {
        return Results.NotFound();
    }

    CuponStore.cuponList.Remove(coupon);

    return Results.NoContent();
});



app.Run();
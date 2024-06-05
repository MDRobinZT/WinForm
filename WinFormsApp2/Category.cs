using Microsoft.EntityFrameworkCore.ChangeTracking;
using WinFormsApp2;

namespace WinFormsApp2;

public class Category
{
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ObservableCollectionListSource<Product> Products { get; } = new();
}
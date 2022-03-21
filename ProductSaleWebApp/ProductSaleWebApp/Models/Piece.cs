namespace ProductSaleWebApp.Models
{
    public class Piece
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Piece()
        {
        }

        public Piece(int id, string name, Category category, int categoryId)
        {
            Id = id;
            Name = name;
            Category = category;
            CategoryId = categoryId;
        }
    }
}

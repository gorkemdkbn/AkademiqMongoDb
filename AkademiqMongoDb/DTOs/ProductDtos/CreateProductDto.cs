using System.ComponentModel.DataAnnotations;

namespace AkademiqMongoDb.DTOs.ProductDtos
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "Ürün Adı Boş Bırakılamaz !")]
        [MinLength(2, ErrorMessage = "Ürün Adı En Az 2 Karakter Olmalıdır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ürün Açıklaması Boş Bırakılamaz !")]
        [MaxLength(250, ErrorMessage = "Ürün Açıklaması 250 Karakteri Geçemez")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Görsel  Boş Bırakılamaz !")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Ürün Fiyatı Boş Bırakılamaz !")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Kategori Adı Boş Bırakılamaz !")]

        public string CategoryName { get; set; }
    }
}

using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir kategori adı girişi yapınız");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız");
        }
    }
}

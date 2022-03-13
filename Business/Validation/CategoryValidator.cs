using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator() 
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("kategori adı bos gecemez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("açıklamayı boş gecemezsınız");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("lütfen 20 karkaterden fazla girmeyin");
        }
    }
}

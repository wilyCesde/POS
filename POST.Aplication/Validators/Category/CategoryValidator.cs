using FluentValidation;
using POS.Aplication.Dtos.Request;
using POS.Aplication.Dtos.Response;

namespace POS.Aplication.Validators.Category
{
    public class CategoryValidator : AbstractValidator<CategoryRequestDto>
    {

        //aqui hacemos nuestras Validaciones 
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("El campo no puede ser nulo.")
                .NotEmpty().WithMessage("El campo nombre no puede ser vacio");
        }

        internal Task ValidateAsync(CategoryResponseDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}

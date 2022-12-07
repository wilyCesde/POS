﻿using POS.Aplication.Commons.Bases;
using POS.Aplication.Dtos.Request;
using POS.Aplication.Dtos.Response;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;

namespace POS.Aplication.Interfaces
{
    public interface ICategoryAplication
    {
        Task<BaseResponse<BaseEntityResponse<CategoryResponseDto>>> ListCategories(BaseFiltersRequest filters);

        Task<BaseResponse<IEnumerable<CategorySelectResponseDto>>> ListSelectCategories();

        Task<BaseResponse<CategoryResponseDto>> CategoryById(int categoryId);

        Task<BaseResponse<bool>> RegisterCategory(CategoryRequestDto requestDto);

        Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryRequestDto requestDto);

        Task<BaseResponse<bool>> RemoveCategory(int categoryId);
    }
}

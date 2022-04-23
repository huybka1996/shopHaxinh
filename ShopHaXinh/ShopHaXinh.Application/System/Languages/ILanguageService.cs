using ShopHaXinh.ViewModels.Common;
using ShopHaXinh.ViewModels.System.Languages;
using ShopHaXinh.ViewModels.System.Users;
using ShopHaXinh.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopHaXinh.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageViewModel>>> GetAll();
    }
}

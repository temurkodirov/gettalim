﻿using GetTalim.DataAccess.Utils;
using GetTalim.DataAccess.ViewModels;
using GetTalim.Domain.Entities.Courses;
using GetTalim.Service.Dtos.CourseModuls;

namespace GetTalim.Service.Interfaces.CourseModuls;

public interface ICourseModulService
{
    public Task<bool> CreateAsync(CourseModulCreateDto dto);
    public Task<CourseModul> GetByIdAsync(long modulId);
    public Task<bool> DeleteAsync(long modulId);
    public Task<IList<CourseModul>> GetAllAsync(PaginationParams @params);
    public Task<bool> UpdateAsync(long  modulId, CourseModulUpdateDto dto);
    public Task<IList<ModulwithVideosViewModel>> GetModulVideosAsync(long courseId);
    public Task<IList<ModulVideosWithoutPathViewModel>> GetModulVideosCommonAsync(long courseId);
}

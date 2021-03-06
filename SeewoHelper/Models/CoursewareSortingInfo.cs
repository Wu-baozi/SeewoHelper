﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SeewoHelper
{
    /// <summary>
    /// 用于为 <see cref="Features.CoursewareSorter"/> 提供数据
    /// </summary>
    public class CoursewareSortingInfo
    {
        /// <summary>
        /// 搜索目录路径
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; }

        /// <summary>
        /// <see cref="SubjectStorageInfo"/> 列表
        /// </summary>
        [JsonPropertyName("subjects")]
        public List<SubjectStorageInfo> Subjects { get; }

        /// <summary>
        /// 创建 <see cref="CoursewareSortingInfo"/> 实例
        /// </summary>
        /// <param name="path">搜索目录路径</param>
        /// <param name="subjects"><see cref="SubjectStorageInfo"/> 列表</param>
        [JsonConstructor]
        public CoursewareSortingInfo(string path, List<SubjectStorageInfo> subjects)
        {
            Path = path;
            Subjects = subjects;
        }
    }
}

﻿// -----------------------------------------------------------------------
//  <copyright file="ITransientDependency.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2015 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-07-29 18:18</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OSharp.Core.Dependency
{
    /// <summary>
    /// 实现此接口的类型将自动注册为<see cref="LifeCycleStyle.Transient"/>模式
    /// </summary>
    public interface ITransientDependency : IDependency
    { }
}
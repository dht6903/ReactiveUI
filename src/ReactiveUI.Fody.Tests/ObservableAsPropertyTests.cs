﻿// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Reactive.Linq;
using ReactiveUI.Fody.Helpers;
using Xunit;

namespace ReactiveUI.Fody.Tests
{
    public class ObservableAsPropertyTests
    {
        [Fact]
        public void TestPropertyReturnsFoo()
        {
            var model = new TestModel();
            Assert.Equal("foo", model.TestProperty);
        }

        public class TestModel : ReactiveObject
        {
            public TestModel()
            {
                Observable.Return("foo").ToPropertyEx(this, x => x.TestProperty);
            }

            [ObservableAsProperty]
            public string TestProperty { get; private set; }
        }
    }
}

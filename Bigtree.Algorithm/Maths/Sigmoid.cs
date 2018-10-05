﻿/*
 * Bigtree.Algorithm
 * Copyright (C) 2018 Haiping Chen
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the Apache License 2.0 as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the Apache License 2.0
 * along with this program.  If not, see <http://www.apache.org/licenses/LICENSE-2.0/>.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Bigtree.Algorithm.Maths
{
    /// <summary>
    /// A sigmoid function is a mathematical function having a characteristic "S"-shaped curve or sigmoid curve. 
    /// </summary>
    public class Sigmoid
    {
        private double x;

        public double y
        {
            get
            {
                return 1 / (1 + Math.Pow(Math.E, -x));
            }
        }

        public Sigmoid(double x)
        {
            this.x = x;
        }
    }
}